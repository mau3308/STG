using System;
using System.Collections.Generic;

namespace STG.WebApi.Models
{
    public partial class Modulo
    {
        public Modulo()
        {
            ModuloObjetoAccíon = new HashSet<ModuloObjetoAccíon>();
        }

        public int ModId { get; set; }
        public string ModDescripcion { get; set; }

        public virtual ICollection<ModuloObjetoAccíon> ModuloObjetoAccíon { get; set; }
    }
}
