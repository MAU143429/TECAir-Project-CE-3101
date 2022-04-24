using Newtonsoft.Json;

namespace TECAir_API.Models.WEB
{
    public class TiqueteVuelo
    {
        public int no_vuelo { get; set; }
        public int no_reservacion { get; set; }
        public string p_nombre { get; set; }
        public string p_apellido1 { get; set; }
        public string p_apellido2 { get; set; }
        public string asiento { get; set; }
        public string origen { get; set; }
        public string ciudad_origen { get; set; }
        public string destino { get; set; }
        public string ciudad_destino { get; set; }
        public string prt_abordaje { get; set; }
        public string v_dia { get; set; }
        public string v_mes { get; set; }
        public string v_ano { get; set; }
        public string h_salida { get; set; }
        public string h_llegada { get; set; }

        public TiqueteVuelo()
        {
        }

        public TiqueteVuelo(int no_vuelo, int no_reservacion, string p_nombre, string p_apellido1, string p_apellido2, string asiento, string origen, string destino, string prt_abordaje, string v_dia, string v_mes, string v_ano, string h_salida, string h_llegada)
        {
            List<AeropuertoWeb> aeropuertos;
            using (StreamReader r = new StreamReader("Assets/airports.json"))
            {
                string json = r.ReadToEnd();
                aeropuertos = JsonConvert.DeserializeObject<List<AeropuertoWeb>>(json);
            }

            for (int i = 0; i < aeropuertos.Count; i++)
            {
                if (aeropuertos[i].nombre == origen)
                    this.ciudad_origen = aeropuertos[i].ciudad;
                if (aeropuertos[i].nombre == destino)
                    this.ciudad_destino = aeropuertos[i].ciudad;
            }

            this.no_vuelo = no_vuelo;
            this.no_reservacion = no_reservacion;
            this.p_nombre = p_nombre;
            this.p_apellido1 = p_apellido1;
            this.p_apellido2 = p_apellido2;
            this.asiento = asiento;
            this.origen = origen;
            this.destino = destino;
            this.prt_abordaje = prt_abordaje;
            this.v_dia = v_dia;
            this.v_mes = v_mes;
            this.v_ano = v_ano;
            this.h_salida = h_salida;
            this.h_llegada = h_llegada;
        }
    }
}