using Dapper;
using TECAir_API.Database.Interface;
using TECAir_API.Models.WebOutput;
using TECAir_API.Database;
using TECAir_API.Models;

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

   

        public async Task<IEnumerable<ReservacionOutput>> GetReservacionId()
        {
            Singleton s = Singleton.Instance();
            String IdUsuario = s.usuario;
            String IdTrabajador = s.usuario;


            var db = dbConnection();


            if (s.usua_trab) {

                var sql = @"
                       SELECT reservacion.no_vuelo, no_reservacion, origen, destino, h_salida, v_dia, v_mes, v_ano 
                       FROM (public.reservacion JOIN public.vuelo ON reservacion.no_vuelo = vuelo.no_vuelo) JOIN public.usuario ON usuario.id_usuario = reservacion.id_usuario
                       WHERE correo = @IdUsuario AND cancelado = false
                        ";

                return await db.QueryAsync<ReservacionOutput>(sql, new
                {
                    IdUsuario = IdUsuario
                });

                
            }
            else {
                var sql = @"
                        SELECT reservacion.no_vuelo, no_reservacion, origen, destino, h_salida, v_dia, v_mes, v_ano 
                        FROM public.reservacion JOIN public.vuelo ON reservacion.no_vuelo = vuelo.no_vuelo
                        WHERE id_trabajador = @IdTrabajador AND cancelado = false
                        ";

                return await db.QueryAsync<ReservacionOutput>(sql, new
                {
                    IdTrabajador = IdTrabajador
                });
                 
            }

        }

        public async Task<bool> ingresarReservacion(Reservacion reservacion)
        {
            var db = dbConnection();
            var sql = "";

            Singleton s = Singleton.Instance();
            if (s.usua_trab)
            {
                sql = @"
                        INSERT INTO reservacion (no_reservacion, cancelado, no_vuelo, id_usuario, id_trabajador)
                        VALUES (@noReservacion, @cancelado, @noVuelo, @idUsuario, NULL);
                        ";
            } else
            {
                sql = @"
                        INSERT INTO reservacion (no_reservacion, cancelado, no_vuelo, id_usuario, id_trabajador)
                        VALUES (@noReservacion, @cancelado, @noVuelo, NULL, @idTrabajador);
                        ";
            }
            

            var result = await db.ExecuteAsync(sql, new
            {
                reservacion.NoReservacion,
                reservacion.Cancelado,
                reservacion.NoVuelo,
                reservacion.IdUsuario,
                reservacion.IdTrabajador,
            });

            return result > 0;
        }
    }
}
