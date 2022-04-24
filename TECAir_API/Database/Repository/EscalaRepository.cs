using Dapper;
using TECAir_API.Database.Interface;

namespace TECAir_API.Database.Repository
{
    public class EscalaRepository : IEscala
    {
        private PostgreSQLConfiguration _connectionString;

        public EscalaRepository(PostgreSQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }

        public async Task<bool> ingresarEscala(Escala escala)
        {
            var db = dbConnection();

            var sql = @"
                        INSERT INTO escala(no_escala, escala, orden, no_vuelo) 
                        VALUES(@noEscala, @escala1, @orden, @noVuelo);
                        ";

            var result = await db.ExecuteAsync(sql, new
            {
                escala.NoEscala,
                escala.Escala1,
                escala.Orden,
                escala.NoVuelo
            });

            return result > 0;
        }
    }
}
