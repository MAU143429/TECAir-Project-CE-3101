using Dapper;
using TECAir_API.Database.Interface;

namespace TECAir_API.Database.Repository
{
    public class AsientoRepository : IAsiento
    {
        private PostgreSQLConfiguration _connectionString;

        public AsientoRepository(PostgreSQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }

        public async Task<bool> ingresarAsiento(Asiento asiento, int no_transaccion)
        {
            var db = dbConnection();

            var sql = @"
                        INSERT INTO asiento (no_asiento, no_vuelo, ubicacion)
                        VALUES (@noAsiento, @noVuelo, @ubicacion);

                        UPDATE public.tiquete
                        SET no_asiento = @noAsiento
                        WHERE no_transaccion = @noTransaccion;
                        ";

            var result = await db.ExecuteAsync(sql, new
            {
                NoAsiento = asiento.NoAsiento,
                NoVuelo = asiento.NoVuelo,
                Ubicacion = asiento.Ubicacion,
                NoTransaccion = no_transaccion
            });

            return result > 0;
        }
    }
}
