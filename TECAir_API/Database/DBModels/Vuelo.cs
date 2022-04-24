using System;
using System.Collections.Generic;

namespace TECAir_API
{
    public partial class Vuelo
    {
        public Vuelo()
        {
            Asientos = new HashSet<Asiento>();
            Escalas = new HashSet<Escala>();
            Maleta = new HashSet<Maletum>();
            Promocions = new HashSet<PromocionOutput>();
            Reservacions = new HashSet<Reservacion>();
        }

        public Vuelo(decimal noVuelo, string origen, string destino, string prtAbordaje, string hSalida, string hLlegada, string vDia, string vMes, string vAno, decimal costeVuelo, string matricula, bool cerrado)
        {
            NoVuelo = noVuelo;
            Origen = origen;
            Destino = destino;
            PrtAbordaje = prtAbordaje;
            HSalida = hSalida;
            HLlegada = hLlegada;
            VDia = vDia;
            VMes = vMes;
            VAno = vAno;
            CosteVuelo = costeVuelo;
            Matricula = matricula;
            Cerrado = cerrado;
        }

        public decimal NoVuelo { get; set; }
        public string Origen { get; set; } = null!;
        public string Destino { get; set; } = null!;
        public string PrtAbordaje { get; set; } = null!;
        public string HSalida { get; set; } = null!;
        public string HLlegada { get; set; } = null!;
        public string VDia { get; set; } = null!;
        public string VMes { get; set; } = null!;
        public string VAno { get; set; } = null!;
        public decimal CosteVuelo { get; set; }
        public string Matricula { get; set; } = null!;
        public bool Cerrado { get; set; }

        public virtual Avion MatriculaNavigation { get; set; } = null!;
        public virtual ICollection<Asiento> Asientos { get; set; }
        public virtual ICollection<Escala> Escalas { get; set; }
        public virtual ICollection<Maletum> Maleta { get; set; }
        public virtual ICollection<PromocionOutput> Promocions { get; set; }
        public virtual ICollection<Reservacion> Reservacions { get; set; }
    }
}
