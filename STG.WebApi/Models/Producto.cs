using System;
using System.Collections.Generic;

namespace STG.WebApi.Models
{
    public partial class Producto
    {
        public Producto()
        {
            CartasPorte = new HashSet<CartasPorte>();
        }

        public int PduId { get; set; }
        public string PduDescripcion { get; set; }

        public virtual ICollection<CartasPorte> CartasPorte { get; set; }
    }
}
