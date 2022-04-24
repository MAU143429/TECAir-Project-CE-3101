using Dapper;
using TECAir_API.Database.Interface;
using TECAir_API.Models;
using TECAir_API.Models.WEB;
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

        public async Task<IEnumerable<TiqueteOutput>> GetTiqueteId()
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
                        FROM ((public.reservacion JOIN public.tiquete ON reservacion.no_reservacion = tiquete.no_reservacion) JOIN public.vuelo ON reservacion.no_vuelo = vuelo.no_vuelo) JOIN public.usuario ON reservacion.id_usuario = usuario.id_usuario
                        WHERE correo = @idUsuario AND cancelado = true 
                        ";

                return await db.QueryAsync<TiqueteOutput>(sql, new
                {
                    IdUsuario = IdUsuario
                });
            } else
            {
                sql = @"
                        SELECT reservacion.no_vuelo, no_transaccion,h_salida,t_dia,t_mes,t_ano
                        FROM (public.reservacion JOIN public.tiquete ON reservacion.no_reservacion = tiquete.no_reservacion) JOIN public.vuelo ON reservacion.no_vuelo = vuelo.no_vuelo 
                        WHERE id_trabajador = @idTrabajador AND cancelado = true
                        ";
                return await db.QueryAsync<TiqueteOutput>(sql, new
                {
                    IdTrabajador = IdTrabajador
                });
            }
        }

        public async Task<IEnumerable<Transaccion>> GetTiqueteNoT(int no_transaccion)
        {
            var db = dbConnection();

            var sql = @"
                        SELECT tiquete.no_transaccion,vuelo.no_vuelo,p_nombre,p_apellido1,p_apellido2,h_salida
                        FROM ((public.tiquete JOIN public.pasajero ON pasajero.no_transaccion = tiquete.no_transaccion) JOIN public.asiento ON tiquete.no_asiento = asiento.no_asiento) JOIN public.vuelo ON vuelo.no_vuelo = asiento.no_vuelo
                        WHERE tiquete.no_transaccion = @noTransaccion AND pasajero.chequeado = false 
                        ";
            return await db.QueryAsync<Transaccion>(sql, new
            {
                NoTransaccion = no_transaccion
            });
        }

        public async Task<bool> Chequear(int no_transaccion)
        {
            var db = dbConnection();

            var sql = @"
                        UPDATE public.pasajero
                        SET chequeado = true
                        WHERE no_transaccion = @notransaccion
                        ";

            var result = await db.ExecuteAsync(sql, new
            {
                NoTransaccion = no_transaccion,
            });

            return result > 0;
        }

        public async Task<bool> ingresarTiquete(GenerarTiquete gTiquete, int no_transaccion)
        {
            var db = dbConnection();

            Tiquete tiquete = new Tiquete(no_transaccion, gTiquete.v_dia, gTiquete.v_mes, gTiquete.v_ano, false, gTiquete.no_reservacion, 0);
            Pasajero pasajero = new Pasajero(gTiquete.dni, gTiquete.p_nombre, gTiquete.p_apellido1, gTiquete.p_apellido2, 0, false, no_transaccion);

            var sql1 = @"
                        INSERT INTO tiquete(no_transaccion, no_reservacion, no_asiento, t_dia, t_mes, t_ano, abordaje)
                        VALUES (@noTransaccion, @NoReservacion, @NoAsiento, @TDia, @TMes, @TAno, @Abordaje);

                        UPDATE public.reservacion
                        SET cancelado = true
                        WHERE no_reservacion = @NoReservacion;

                        INSERT INTO pasajero(dni, no_transaccion, p_nombre, p_apellido1, p_apellido2, cant_maletas, chequeado)
                        VALUES (@Dni, @NoTransaccion, @PNombre, @PApellido1, @PApellido2, @CantMaletas, @Chequeado);
                        ";

            var result1 = await db.ExecuteAsync(sql1, new
            {
                NoTransaccion = tiquete.NoTransaccion,
                NoReservacion = tiquete.NoReservacion,
                NoAsiento = tiquete.NoAsiento,
                TDia = tiquete.TDia,
                TMes = tiquete.TMes,
                TAno = tiquete.TAno,
                Abordaje = tiquete.Abordaje,
                Dni = pasajero.Dni,
                PNombre = pasajero.PNombre,
                PApellido1 = pasajero.PApellido1,
                PApellido2 = pasajero.PApellido2,
                CantMaletas = pasajero.CantMaletas,
                Chequeado = pasajero.Chequeado
            });

            return result1 > 0;
        }

        public async Task<IEnumerable<TiqueteVuelo>> GenerarTiquete(int no_transaccion)
        {
            var db = dbConnection();
            var sql = @"
                        SELECT vuelo.no_vuelo, reservacion.no_reservacion, p_nombre, p_apellido1, p_apellido2, ubicacion, origen, origen, destino, destino, prt_abordaje, v_dia, v_mes, v_ano, h_salida, h_llegada
                        FROM (((public.tiquete JOIN public.reservacion ON tiquete.no_reservacion = reservacion.no_reservacion)
                        JOIN public.pasajero ON tiquete.dni = pasajero.dni)
                        JOIN public.asiento ON tiquete.no_asiento = asiento.no_asiento)
                        JOIN public.vuelo ON tiquete.no_vuelo = vuelo.no_vuelo
                        WHERE tiquete.no_tiquete = @noTransaccion
                        ";

            return await db.QueryAsync<TiqueteVuelo>(sql, new
            {
                NoTransaccion = no_transaccion
            });
        }
    }
}
