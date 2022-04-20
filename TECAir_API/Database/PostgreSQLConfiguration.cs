using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TECAir_API.Database
{
    public class PostgreSQLConfiguration
    {
        /// <summary>
        /// Metodo para configuracion de la conexion con la base de datos
        /// </summary>
        /// <param name="connectionString"> conexion entrante</param>
        public PostgreSQLConfiguration(string connectionString) => ConnectionString = connectionString;

        public string ConnectionString { get; set; }
    }
}
