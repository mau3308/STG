using System;
using System.Collections.Generic;

namespace STG.WebApi.Models
{
    public partial class Objeto
    {
        public Objeto()
        {
            ModuloObjetoAccíon = new HashSet<ModuloObjetoAccíon>();
        }

        public int ObjId { get; set; }
        public string ObjDescripcion { get; set; }

        public virtual ICollection<ModuloObjetoAccíon> ModuloObjetoAccíon { get; set; }
    }
}
