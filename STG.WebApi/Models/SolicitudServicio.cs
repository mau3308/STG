using System;
using System.Collections.Generic;

namespace STG.WebApi.Models
{
    public partial class SolicitudServicio
    {
        public SolicitudServicio()
        {
            DetalleServicioAdicional = new HashSet<DetalleServicioAdicional>();
        }

        public int SolId { get; set; }
        public DateTime SolFechaEmision { get; set; }
        public DateTime? SolFechaAutorizacion { get; set; }
        public bool SolCalidadComoServicio { get; set; }
        public string SolFormaPagoAdicionales { get; set; }
        public decimal SolPorcRebaja { get; set; }
        public int SolKilosRebaja { get; set; }
        public decimal SolImporteRebaja { get; set; }
        public int SolUsuIdAcondicionador { get; set; }

        public virtual Usuario SolUsuIdAcondicionadorNavigation { get; set; }
        public virtual ICollection<DetalleServicioAdicional> DetalleServicioAdicional { get; set; }
    }
}
