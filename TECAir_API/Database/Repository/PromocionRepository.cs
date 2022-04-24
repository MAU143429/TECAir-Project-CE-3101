using Dapper;
using Newtonsoft.Json;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TECAir_API.Models;
using TECAir_API.Models.WEB;
using TECAir_API.Models.WebOutput;

namespace TECAir_API.Database.Repository
{
    public class PromocionRepository : IPromocion
    {
        private PostgreSQLConfiguration _connectionString;

        public PromocionRepository(PostgreSQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }
        
        public async Task<bool> ingresarPromocion(Promocion promocion)
        {
            var db = dbConnection();

            var sql = @"
                        INSERT INTO promocion (no_promocion, porcentaje, periodo, url, p_dia, p_mes, p_ano, no_vuelo)
                        VALUES (@nopromocion,@porcentaje, @periodo, @url, @pDia, @pMes, @pAno, @noVuelo);
                        ";

            var result = await db.ExecuteAsync(sql, new
            {
                promocion.NoPromocion,
                promocion.Porcentaje,
                promocion.Periodo,
                promocion.Url,
                promocion.PDia,
                promocion.PMes,
                promocion.PAno,
                promocion.NoVuelo
            });

            return result > 0;
        }

        public async Task<IEnumerable<PromosRandom>> GetPromociones()
        {
            var db = dbConnection();

            var sql = @"
                        SELECT no_promocion, porcentaje, url, p_dia, p_mes, p_ano, vuelo.no_vuelo, origen, destino, coste_vuelo
                        FROM public.promocion JOIN public.vuelo ON vuelo.no_vuelo = promocion.no_vuelo
                        ";

            var temp = await db.QueryAsync<PromosOutput>(sql, new { });
            List<PromosOutput> output = (List<PromosOutput>) temp;

            List<PromosRandom> result = new List<PromosRandom>();
            List<AeropuertoWeb> aeropuertos;
            using (StreamReader r = new StreamReader("Assets/airports.json"))
            {
                string json = r.ReadToEnd();
                aeropuertos = JsonConvert.DeserializeObject<List<AeropuertoWeb>>(json);
            }

            for (int i = 0; i < output.Count; i++)
            {
                for (int j = 0; j < aeropuertos.Count; j++)
                {
                    if (output[i].Origen == aeropuertos[j].nombre)
                        output[i].Origen = aeropuertos[j].ciudad;
                    if (output[i].Destino == aeropuertos[j].nombre)
                        output[i].Destino = aeropuertos[j].ciudad;
                }
            }

            Random rng = new Random();
            while (result.Count < 8)
            {
                int k = rng.Next(output.Count-1);
                result.Add(new PromosRandom(output[k].NoVuelo, output[k].NoPromocion, output[k].Url, output[k].Origen, output[k].Destino, output[k].PDia, output[k].PMes, output[k].PAno, output[k].Porcentaje, output[k].CosteVuelo*(100- output[k].Porcentaje)/100));
                output.Remove(output[k]);
            }
            return result;
        }
    }
}
