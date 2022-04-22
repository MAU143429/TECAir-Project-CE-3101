using Dapper;
using TECAir_API.Database.Interface;

namespace TECAir_API.Database.Repository
{
    public class UsuarioRepository : IUsuario
    {

        private PostgreSQLConfiguration _connectionString;

        public UsuarioRepository(PostgreSQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }
        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }

        public async Task<bool> ingresarUsuario(Usuario usuario)
        {
            var db = dbConnection();

            var sql = @"
                        INSERT INTO usuario (id_usuario, u_nombre, u_apellido1, u_apellido2, correo, u_contrasena, telefono)
                        VALUES (@IdUsuario, @uNombre, @uApellido1, @uApellido2, @Correo, @uContrasena, @Telefono);
                        ";

            var result = await db.ExecuteAsync(sql, new
            {
                usuario.IdUsuario,
                usuario.UNombre,
                usuario.UApellido1,
                usuario.UApellido2,
                usuario.Correo,
                usuario.UContrasena,
                usuario.Telefono,
                
            });

            return result > 0;
        }

        public async Task<bool> ingresarEstudiante(Estudiante estudiante)
        {
            var db = dbConnection();

            var sql = @"
                        INSERT INTO estudiante (carne, universidad, id_usuario)
                        VALUES (@carne, @universidad, @idUsuario);
                        ";

            var result = await db.ExecuteAsync(sql, new
            {
                estudiante.Carne,
                estudiante.Universidad,
                estudiante.IdUsuario
                
            });

            return result > 0;
        }
    }
}
