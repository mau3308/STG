using System;
using System.Collections.Generic;

namespace STG.WebApi.Models
{
    public partial class DetalleServicioAdicional
    {
        public int DsaId { get; set; }
        public int DsaSerId { get; set; }
        public int DsaSolId { get; set; }
        public decimal DsaTarifaPorTn { get; set; }
        public decimal DsaImporte { get; set; }
        public decimal? DsaImporteDef { get; set; }
        public decimal DsaImporteKilos { get; set; }
        public decimal? DsaImporteKilosDef { get; set; }
        public bool DsaAutoriza { get; set; }

        public virtual Servicio DsaSer { get; set; }
        public virtual SolicitudServicio DsaSol { get; set; }
    }
}
