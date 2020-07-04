using System;
using System.Collections.Generic;

namespace STG.WebApi.Models
{
    public partial class Accion
    {
        public Accion()
        {
            ModuloObjetoAccíon = new HashSet<ModuloObjetoAccíon>();
        }

        public int AccId { get; set; }
        public string AccDescripcion { get; set; }

        public virtual ICollection<ModuloObjetoAccíon> ModuloObjetoAccíon { get; set; }
    }
}
