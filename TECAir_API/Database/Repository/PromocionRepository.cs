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
                    if (output[i].origen == aeropuertos[j].nombre)
                        output[i].origen = aeropuertos[j].ciudad;
                    if (output[i].destino == aeropuertos[j].nombre)
                        output[i].destino = aeropuertos[j].ciudad;
                }
            }

            Random rng = new Random();
            while (result.Count < 8)
            {
                int k = rng.Next(output.Count);
                result.Add(new PromosRandom(output[k].no_vuelo, output[k].no_promocion, output[k].url, output[k].origen, output[k].destino, output[k].p_dia, output[k].p_mes, output[k].p_ano, output[k].porcentaje, output[k].coste_vuelo*(100- output[k].porcentaje)/100));
                output.Remove(output[k]);
            }
            return result;
        }
    }
}
