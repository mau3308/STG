using System;
using System.Collections.Generic;

namespace STG.WebApi.Models
{
    public partial class CartasPorte
    {
        public int CpoId { get; set; }
        public DateTime CpoFechaEmision { get; set; }
        public DateTime CpoFechaDescarga { get; set; }
        public int CpoKgProcedencia { get; set; }
        public int? CpoKgDescargados { get; set; }
        public string CpoCtg { get; set; }
        public int CpoPduId { get; set; }
        public int CpoCosecha { get; set; }
        public int CpoUsuCodigoVendedor { get; set; }
        public int CpoUsuCodigoComprador { get; set; }
        public int CpoUsuCodigoEntregador { get; set; }
        public string CpoProcedencia { get; set; }
        public string CpoDestino { get; set; }
        public string CpoPatenteTransporte { get; set; }
        public string CpoEstado { get; set; }

        public virtual Producto CpoPdu { get; set; }
        public virtual Usuario CpoUsuCodigoCompradorNavigation { get; set; }
        public virtual Usuario CpoUsuCodigoEntregadorNavigation { get; set; }
        public virtual Usuario CpoUsuCodigoVendedorNavigation { get; set; }
    }
}
