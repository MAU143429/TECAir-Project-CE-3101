using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TECAir_API.Database
{
    public class PostgreSQLConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        public PostgreSQLConfiguration(string connectionString) => ConnectionString = connectionString;

        public string ConnectionString { get; set; }
    }
}
