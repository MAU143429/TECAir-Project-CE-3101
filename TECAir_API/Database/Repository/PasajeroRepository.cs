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
            var sql1 = @"
                        INSERT INTO tiquete(no_transaccion, no_reservacion, no_asiento, t_dia, t_mes, t_ano, abordaje)
                        VALUES (@notransaccion, @noreservacion, @noasiento, @tdia, @tmes, @tano, @abordaje);
                        ";

            var result1 = await db.ExecuteAsync(sql1, new
            {
                tiquete.NoTransaccion,
                tiquete.NoReservacion,
                tiquete.NoAsiento,
                tiquete.TDia,
                tiquete.TMes,
                tiquete.TAno,
                tiquete.Abordaje
            });

            var sql2 = @"
                        UPDATE public.reservacion
                        SET cancelado = true
                        WHERE no_reservacion = @noreservacion 
                        ";

            var resultado2 = await db.ExecuteAsync(sql2, new
            {
                NoReservacion = gTiquete.no_reservacion
            });

            Pasajero pasajero = new Pasajero(gTiquete.dni, gTiquete.p_nombre, gTiquete.p_apellido1, gTiquete.p_apellido2, 0, false, no_transaccion);
            var sql3 = @"
                        INSERT INTO pasajero(dni, no_transaccion, p_nombre, p_apellido1, p_apellido2, cant_maletas, chequeado)
                        VALUES (@dni, @noTransaccion, @pNombre, @pApellido1, @pApellido2, 0, false);
                        ";

            var result3 = await db.ExecuteAsync(sql3, new
            {
                pasajero.Dni,
                pasajero.NoTransaccion,
                pasajero.PNombre,
                pasajero.PApellido1,
                pasajero.PApellido2,
                pasajero.CantMaletas,
                pasajero.Chequeado
            });

            return result3 > 0;
        }
    }
}
