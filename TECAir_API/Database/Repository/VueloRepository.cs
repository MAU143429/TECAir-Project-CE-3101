using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TECAir_API.Database.Interface;

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


    }
}
