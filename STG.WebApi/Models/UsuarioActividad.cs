using System;
using System.Collections.Generic;

namespace STG.WebApi.Models
{
    public partial class UsuarioActividad
    {
        public int UsaUsuCodigo { get; set; }
        public int UsaActId { get; set; }
        public string UsaEstado { get; set; }

        public virtual Actividad UsaAct { get; set; }
        public virtual Usuario UsaUsuCodigoNavigation { get; set; }
    }
}
