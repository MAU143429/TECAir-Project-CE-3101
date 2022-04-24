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

        public async Task<bool> ingresarAsiento(Asiento asiento)
        {
            var db = dbConnection();

            var sql = @"
                        INSERT INTO asiento (no_asiento, no_vuelo, ubicacion)
                        VALUES (@noAsiento, @noVuelo, @ubicacion);
                        ";

            var result = await db.ExecuteAsync(sql, new
            {
                NoAsiento = asiento.NoAsiento,
                NoVuelo = asiento.NoVuelo,
                Ubicacion = asiento.Ubicacion
            });

            return result > 0;
        }
    }
}
