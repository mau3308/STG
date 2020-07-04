using System;
using System.Collections.Generic;

namespace STG.WebApi.Models
{
    public partial class Actividad
    {
        public Actividad()
        {
            UsuarioActividad = new HashSet<UsuarioActividad>();
        }

        public int ActId { get; set; }
        public string ActDescripcion { get; set; }

        public virtual ICollection<UsuarioActividad> UsuarioActividad { get; set; }
    }
}
