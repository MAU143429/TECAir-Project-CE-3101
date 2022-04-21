using Dapper;
using TECAir_API.Database.Interface;
using TECAir_API.Models.WebOutput;
using TECAir_API.Database;

namespace TECAir_API.Database.Repository
{
    public class ReservacionRepository : IReservacion
    {
        private PostgreSQLConfiguration _connectionString;

        public ReservacionRepository(PostgreSQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }

        public async Task<ReservacionOutput> GetReservacionId(decimal idUsuario)
        {
            var db = dbConnection();

            var sql = @"
                        SELECT reservacion.no_vuelo, no_reservacion, origen, destino, h_salida, v_dia, v_mes, v_ano 
                        FROM public.reservacion JOIN public.vuelo ON reservacion.no_vuelo = vuelo.no_vuelo
                        WHERE id_usuario = @idusuario AND cancelado = false
                        ";

            return await db.QueryFirstOrDefaultAsync<ReservacionOutput>(sql,new 
            { 
               IdUsuario = idUsuario
            });
        }

        public async Task<ReservacionOutput> GetReservacionId(string idTrabajador)
        {
            var db = dbConnection();

            var sql = @"
                        SELECT reservacion.no_vuelo, no_reservacion, origen, destino, h_salida, v_dia, v_mes, v_ano 
                        FROM public.reservacion JOIN public.vuelo ON reservacion.no_vuelo = vuelo.no_vuelo
                        WHERE id_trabajador = @idtrabajador AND cancelado = false
                        ";

            return await db.QueryFirstOrDefaultAsync<ReservacionOutput>(sql, new
            {
                IdTrabajador = idTrabajador
            });
        }
    }
}
