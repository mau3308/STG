using System;
using System.Collections.Generic;

namespace STG.WebApi.Models
{
    public partial class Servicio
    {
        public Servicio()
        {
            DetalleServicioAdicional = new HashSet<DetalleServicioAdicional>();
        }

        public int SerId { get; set; }
        public string SerDescripcion { get; set; }
        public bool SerOpcional { get; set; }

        public virtual ICollection<DetalleServicioAdicional> DetalleServicioAdicional { get; set; }
    }
}
