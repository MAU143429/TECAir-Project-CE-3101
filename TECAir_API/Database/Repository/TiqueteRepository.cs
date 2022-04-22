using Dapper;
using TECAir_API.Database.Interface;
using TECAir_API.Models.WebOutput;

namespace TECAir_API.Database.Repository
{
    public class TiqueteRepository : ITiquete
    {
        private PostgreSQLConfiguration _connectionString;

        public TiqueteRepository(PostgreSQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }

        public async Task<TiqueteOutput> GetReservacionId(decimal idUsuario)
        {
            var db = dbConnection();

            var sql = @"
                        SELECT reservacion.no_vuelo, no_transaccion,h_salida,t_dia,t_mes,t_ano
                        FROM (public.reservacion JOIN public.tiquete ON reservacion.no_reservacion = tiquete.no_reservacion) JOIN public.vuelo ON reservacion.no_vuelo = vuelo.no_vuelo 
                        WHERE id_usuario = @idUsuario AND cancelado = true  
                        ";

            return await db.QueryFirstOrDefaultAsync<TiqueteOutput>(sql, new
            {
                IdUsuario = idUsuario
            });
        }

        public async Task<TiqueteOutput> GetReservacionId(string idTrabajador)
        {
            var db = dbConnection();

            var sql = @"
                        SELECT reservacion.no_vuelo, no_transaccion,h_salida,t_dia,t_mes,t_ano
                        FROM (public.reservacion JOIN public.tiquete ON reservacion.no_reservacion = tiquete.no_reservacion) JOIN public.vuelo ON reservacion.no_vuelo = vuelo.no_vuelo 
                        WHERE id_usuario = @idTrabajador AND cancelado = true  
                        ";

            return await db.QueryFirstOrDefaultAsync<TiqueteOutput>(sql, new
            {
                IdTrabajador = idTrabajador
            });
        }
    }
}
