using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TECAir_API
{
    public partial class PromocionOutput
    {
        [Key]  
        public decimal NoPromocion { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal Periodo { get; set; }
        public string Url { get; set; } = null!;
        public string PDia { get; set; } = null!;
        public string PMes { get; set; } = null!;
        public string PAno { get; set; } = null!;
        public decimal NoVuelo { get; set; }

        public virtual Vuelo NoVueloNavigation { get; set; } = null!;

        public PromocionOutput()
        {
        }

        public PromocionOutput(decimal noPromocion, decimal porcentaje, decimal periodo, string url, string pDia, string pMes, string pAno, decimal noVuelo)
        {
            NoPromocion = noPromocion;
            Porcentaje = porcentaje;
            Periodo = periodo;
            Url = url;
            PDia = pDia;
            PMes = pMes;
            PAno = pAno;
            NoVuelo = noVuelo;
        }
    }
}
