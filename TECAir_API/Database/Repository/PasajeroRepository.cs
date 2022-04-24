using Dapper;
using TECAir_API.Database.Interface;
using TECAir_API.Models.Automation;
using TECAir_API.Models.WEB;

namespace TECAir_API.Database.Repository
{
    public class PasajeroRepository : IPasajero
    {
        private PostgreSQLConfiguration _connectionString;

        public PasajeroRepository(PostgreSQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }

        public async Task<bool> GenerarTiquete(GenerarTiquete gTiquete, int no_transaccion)
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
    }
}
