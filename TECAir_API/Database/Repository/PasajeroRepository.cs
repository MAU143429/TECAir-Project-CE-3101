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

            var sql = @"
                        INSERT INTO tiquete(no_transaccion, no_reservacion, no_asiento, t_dia, t_mes, t_ano, abordaje)
                        VALUES (@noTransaccion, @noReservacion, NULL, @vDia, @vMes, @vAno, false);

                        UPDATE public.reservacion
                        SET cancelado = true
                        WHERE no_reservacion = @noReservacion    

                        INSERT INTO pasajero(dni, no_transaccion, p_nombre, p_apellido1, p_apellido2, cant_maletas, chequeado)
                        VALUES (@dni, @noTransaccion, @pNombre, @pApellido1, @pApellido2, 0, false);
                        ";

            var result = await db.ExecuteAsync(sql, new
            {
                NoTransaccion = no_transaccion,
                NoReservacion = gTiquete.no_reservacion,
                VDia = gTiquete.v_dia,
                VMes = gTiquete.v_mes,
                VAno = gTiquete.v_ano,
                Dni = gTiquete.dni,
                PNombre = gTiquete.p_nombre,
                PApellido1 = gTiquete.p_apellido1,
                PApellido2 = gTiquete.p_apellido2
            });

            return result > 0;
        }
    }
}
