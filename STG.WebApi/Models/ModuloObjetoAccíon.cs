using System;
using System.Collections.Generic;

namespace STG.WebApi.Models
{
    public partial class ModuloObjetoAccíon
    {
        public int MoaId { get; set; }
        public int MoaModId { get; set; }
        public int MoaObjId { get; set; }
        public int MoaAccId { get; set; }

        public virtual Accion MoaAcc { get; set; }
        public virtual Modulo MoaMod { get; set; }
        public virtual Objeto MoaObj { get; set; }
    }
}
