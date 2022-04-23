using Dapper;
using Newtonsoft.Json;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TECAir_API.Database.Interface;
using TECAir_API.Models;
using TECAir_API.Models.WEB;
using TECAir_API.Models.WebOutput;

namespace TECAir_API.Database.Repository
{
    public class VueloRepository: IVuelo
    {
        private PostgreSQLConfiguration _connectionString;

        public VueloRepository(PostgreSQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }

        public async Task<bool> ingresarVuelo(Vuelo vuelo)
        {
            var db = dbConnection();

            var sql = @"
                        INSERT INTO vuelo (no_vuelo, origen, destino, prt_abordaje, h_salida, h_llegada, v_dia, v_mes,v_ano,coste_vuelo,matricula,cerrado)
                        VALUES (@novuelo,@origen, @destino, @prtAbordaje, @Hsalida, @Hllegada, @vDia, @vMes,@vAno,@costevuelo,@matricula,@cerrado);
                        ";

            var result = await db.ExecuteAsync(sql, new
            {
                vuelo.NoVuelo,
                vuelo.Origen,
                vuelo.Destino,
                vuelo.PrtAbordaje,
                vuelo.HSalida,
                vuelo.HLlegada,
                vuelo.VDia,
                vuelo.VMes,
                vuelo.VAno,
                vuelo.CosteVuelo,
                vuelo.Matricula,
                vuelo.Cerrado,
            });

            return result > 0;
        }

        public async Task<VueloCerradoOutput> GetInfoVueloCerrado(int no_vuelo)
        {
            var db = dbConnection();

            var sql = @"
                        SELECT no_vuelo, origen, destino, h_salida
                        FROM public.vuelo
                        WHERE no_vuelo = @novuelo
                        ";

            return await db.QueryFirstOrDefaultAsync<VueloCerradoOutput>(sql, new
            {
                NoVuelo = no_vuelo
            });
        }
        /// <summary>
        /// Metodo Get
        /// </summary>
        /// <param name="no_transaccion"></param>
        /// <returns></returns>
        public async Task<VueloAbiertoOutput> GetInfoVueloAbierto(int no_transaccion)
        {
            var db = dbConnection();

            var sql = @"
                        SELECT reservacion.no_vuelo, p_nombre,p_apellido1,p_apellido2, vuelo.origen, vuelo.destino, tiquete.abordaje, tiquete.no_transaccion
                        FROM (public.tiquete 
	                            JOIN public.pasajero ON tiquete.no_transaccion = pasajero.no_transaccion
	                            JOIN public.reservacion ON tiquete.no_reservacion = reservacion.no_reservacion) 
                             JOIN public.vuelo ON reservacion.no_vuelo = vuelo.no_vuelo
                        WHERE tiquete.no_transaccion = @notransaccion
                        ";

            return await db.QueryFirstOrDefaultAsync <VueloAbiertoOutput>(sql, new
            {
                NoTransaccion = no_transaccion
            });
        }
        /// <summary>
        /// Encargada de actualizar el estado de abordaje en la tabla tiquete
        /// </summary>
        /// <param name="tiquete"> objeto de tipo tiquete del que se toma el numero de transaccion</param>
        /// <returns></returns>
        public async Task<bool> UpdateEstadoAbordaje(TiqueteWeb tiquete)
        {
            var db = dbConnection();

            var sql = @"
                        UPDATE public.tiquete
                        SET abordaje = true
                        WHERE abordaje = @abordaje AND no_transaccion = @notransaccion    
                        ";
            
            var resultado = await db.ExecuteAsync(sql, new 
            { 
                NoTransaccion = tiquete.no_transaccion,
                Abordaje = false
            });
            
            return resultado>0;
        }

        public async Task<IEnumerable<BusquedaOutput>> GetVuelos(string origen, string destino, string v_dia, string v_mes, string v_ano)
        {
            var db = dbConnection();

            var sql = @"
                        SELECT vuelo.no_vuelo,h_salida,h_llegada,coste_vuelo,v_dia,v_mes,v_ano,coste_vuelo,origen,destino
                        FROM public.vuelo
                        WHERE origen = @origen AND destino = @destino AND v_dia = @v_dia AND v_mes = @v_mes AND v_ano = @v_ano
                        ";

            return await db.QueryAsync<BusquedaOutput>(sql, new
            {
                origen = origen,
                destino = destino,
                v_dia = v_dia,
                v_mes = v_mes,
                v_ano = v_ano

            }) ;
        }

        public async Task<VueloCompleto> GetVueloR(int no_vuelo, int no_reservacion, int escalas)
        {
            var db = dbConnection();

            var sql = @"
                        SELECT origen, destino,h_salida,h_llegada,v_dia,v_mes,v_ano,matricula,prt_abordaje
                        FROM public.vuelo
                        WHERE no_vuelo = @noVuelo
                        ";

            var temp = await db.QueryFirstOrDefaultAsync<BusquedaVuelo>(sql, new
            {
                NoVuelo = no_vuelo
            });

            string origenC = "";
            string destinoC = "";

            List<AeropuertoWeb> aeropuertos;
            using (StreamReader r = new StreamReader("Assets/airports.json"))
            {
                string json = r.ReadToEnd();
                aeropuertos = JsonConvert.DeserializeObject<List<AeropuertoWeb>>(json);
            }
            for (int i = 0; i < aeropuertos.Count; i++)
            {
                if (aeropuertos[i].nombre == temp.origen)
                {
                    origenC = aeropuertos[i].ciudad;
                }
                if (aeropuertos[i].nombre == temp.destino)
                {
                    destinoC = aeropuertos[i].ciudad;
                }
            }

            if (temp == null)
                temp = new BusquedaVuelo();
            VueloCompleto vuelo = new VueloCompleto(no_vuelo, no_reservacion, temp.origen, origenC, temp.destino, destinoC, temp.matricula, temp.prt_abordaje, temp.v_dia, temp.v_mes, temp.v_ano, temp.h_llegada, escalas);
            return vuelo;
        }
    }
}
