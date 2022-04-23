using Dapper;
using TECAir_API.Database.Interface;
using TECAir_API.Models;
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

        public async Task<TiqueteOutput> GetReservacionId()
        {
            var db = dbConnection();
            Singleton s = Singleton.Instance();
            String IdUsuario = s.usuario;
            String IdTrabajador = s.usuario;

            var sql = "";

            if (s.usua_trab)
            {
                sql = @"
                        SELECT reservacion.no_vuelo, no_transaccion,h_salida,t_dia,t_mes,t_ano
                        FROM (public.reservacion JOIN public.tiquete ON reservacion.no_reservacion = tiquete.no_reservacion) JOIN public.vuelo ON reservacion.no_vuelo = vuelo.no_vuelo 
                        WHERE id_usuario = @idUsuario AND cancelado = true  
                        ";

                return await db.QueryFirstOrDefaultAsync<TiqueteOutput>(sql, new
                {
                    IdUsuario = IdUsuario
                });
            } else
            {
                sql = @"
                        SELECT reservacion.no_vuelo, no_transaccion,h_salida,t_dia,t_mes,t_ano
                        FROM (public.reservacion JOIN public.tiquete ON reservacion.no_reservacion = tiquete.no_reservacion) JOIN public.vuelo ON reservacion.no_vuelo = vuelo.no_vuelo 
                        WHERE id_usuario = @idTrabajador AND cancelado = true  
                        ";
                return await db.QueryFirstOrDefaultAsync<TiqueteOutput>(sql, new
                {
                    IdTrabajador = IdTrabajador
                });
            }
        }
    }
}
