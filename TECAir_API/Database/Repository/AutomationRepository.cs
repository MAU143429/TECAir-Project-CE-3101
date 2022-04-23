using Dapper;
using Newtonsoft.Json.Linq;
using TECAir_API.Database.Interface;
using TECAir_API.Models;
using TECAir_API.Models.Automation;
using TECAir_API.Models.WEB;

namespace TECAir_API.Database.Repository
{
    public class AutomationRepository : IAutomation
    {
        private PostgreSQLConfiguration _connectionString;

        public AutomationRepository(PostgreSQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }
        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }

        public async Task<VuelosTotales> GetTotalVuelos()
        {
            var db = dbConnection();

            var sql = @"
                        SELECT *
                        FROM public.vuelo
                        ";
            var test = await db.QueryAsync<Vuelo>(sql, new { });
            var total = Enumerable.Count(test);
            VuelosTotales vuelosTotales = new VuelosTotales(total);
            return vuelosTotales;

        }
        public async Task<ReservacionesTotales> GetTotalReservaciones()
        {
            var db = dbConnection();

            var sql = @"
                        SELECT *
                        FROM public.reservacion
                        ";
            var test = await db.QueryAsync<Reservacion>(sql, new { });
            var total = Enumerable.Count(test);
            ReservacionesTotales reservacionesTotales = new ReservacionesTotales(total);
            return reservacionesTotales;

        }
        public async Task<PromocionesTotales> GetTotalPromociones()
        {
            var db = dbConnection();

            var sql = @"
                        SELECT *
                        FROM public.promocion
                        ";
            var test = await db.QueryAsync<Promocion>(sql, new { });
            var total = Enumerable.Count(test);
            PromocionesTotales promocionesTotales = new PromocionesTotales(total);
            return promocionesTotales;

        }
        public async Task<MaletasTotales> GetTotalMaletas()
        {
            var db = dbConnection();

            var sql = @"
                        SELECT *
                        FROM public.maleta
                        ";
            var test = await db.QueryAsync<Maletum>(sql, new { });
            var total = Enumerable.Count(test);
            MaletasTotales maletasTotales = new MaletasTotales(total);
            return maletasTotales;

        }
        public async Task<TiquetesTotales> GetTotalTiquetes()
        {
            var db = dbConnection();

            var sql = @"
                        SELECT *
                        FROM public.tiquete
                        ";
            var test = await db.QueryAsync<Tiquete>(sql, new { });
            var total = Enumerable.Count(test);
            TiquetesTotales tiquetesTotales = new TiquetesTotales(total);
            return tiquetesTotales;

        }

        public async Task<UsuariosTotales> GetTotalUsuarios()
        {
            var db = dbConnection();

            var sql = @"
                        SELECT *
                        FROM public.usuario
                        ";
            var test = await db.QueryAsync<Tiquete>(sql, new { });
            var total = Enumerable.Count(test);
            UsuariosTotales usuariosTotales = new UsuariosTotales(total);
            return usuariosTotales;

        }


        public async Task<CantEscalas> GetEscalas(int no_vuelo)
        {
            var db = dbConnection();

            var sql = @"
                        SELECT COUNT (*)
                        FROM public.escala
                        WHERE no_vuelo = @novuelo
                        ";
            var test = await db.QueryAsync<Tiquete>(sql, new { });
            var total = Enumerable.Count(test);
            CantEscalas escalas = new CantEscalas(total);
            return escalas;
        }



        public async Task<IEnumerable<Login>> LoginUser(string correo, string contrasena)
        {
            var db = dbConnection();

            var sql = @"
                        SELECT  u_contrasena
                        FROM public.usuario 
                        WHERE correo = @correo
                        ";

            var temp = await db.QueryFirstOrDefaultAsync<Contrasena>(sql, new
            {
                Correo = correo
            });

            if (temp.u_contrasena == null)
                temp = new Contrasena("");

            Login resultlogin = new Login();
            Singleton singleton = Singleton.Instance();
            singleton.usuario = correo;

            if (temp.u_contrasena == contrasena)
            {
                resultlogin.status = true;
                singleton.usua_trab = true;
            }
            else
            {
                resultlogin.status = false;
            }

            return new List<Login>() { resultlogin };


        }

        public async Task<IEnumerable<Login>> LoginTrabajador(string id_trabajador, string contrasena)
        {
            var db = dbConnection();

            var sql = @"
                        SELECT  t_contrasena
                        FROM public.trabajador 
                        WHERE id_trabajador = @idTrabajador
                        ";

            var temp = await db.QueryFirstOrDefaultAsync<ContrasenaTrab>(sql, new
            {
                IdTrabajador = id_trabajador
            });

            if (temp.t_contrasena == null)
                temp = new ContrasenaTrab("");

            Login resultlogin = new Login();
            Singleton singleton = Singleton.Instance();
            singleton.usuario = id_trabajador;

            if (temp.t_contrasena == contrasena)
            {
                resultlogin.status = true;
                singleton.usua_trab = false;
            }
            else
            {
                resultlogin.status = false;
            }

            return new List<Login>() { resultlogin };
        }
    }
}
