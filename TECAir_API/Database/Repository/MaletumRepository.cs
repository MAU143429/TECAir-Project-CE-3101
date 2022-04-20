using Dapper;
using TECAir_API.Database.Interface;

namespace TECAir_API.Database.Repository
{
    public class MaletumRepository: IMaletum
    {
        private PostgreSQLConfiguration _connectionString;

        public MaletumRepository(PostgreSQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }

        public async Task<bool> ingresarMaleta(Maletum maleta)
        {
            var db = dbConnection();

            var sql = @"
                        INSERT INTO maleta (no_maleta, color, peso, dni, no_vuelo)
                        VALUES (@nomaleta,@color, @peso, @dni,@noVuelo);
                        ";

            var result = await db.ExecuteAsync(sql, new
            {
                maleta.NoMaleta,
                maleta.Color,
                maleta.Peso,
                maleta.NoVuelo,
                maleta.Dni

            });

            return result > 0;
        }

    }
}
