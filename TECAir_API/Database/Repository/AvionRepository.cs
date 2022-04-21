using Dapper;
using TECAir_API.Database.Interface;
using TECAir_API.Models.WEB;

namespace TECAir_API.Database.Repository
{
    public class AvionRepository: IAvion
    {
        private PostgreSQLConfiguration _connectionString;

        public AvionRepository(PostgreSQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }

        public async Task<IEnumerable<ListaAvion>> GetAviones()
        {
            var db = dbConnection();

            var sql = @"
                        SELECT matricula, av_nombre
                        FROM public.avion
                        ";

            return await db.QueryAsync<ListaAvion>(sql, new { });
        }
    }
}
