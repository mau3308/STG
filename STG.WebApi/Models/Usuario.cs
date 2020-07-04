using System;
using System.Collections.Generic;

namespace STG.WebApi.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            CartasPorteCpoUsuCodigoCompradorNavigation = new HashSet<CartasPorte>();
            CartasPorteCpoUsuCodigoEntregadorNavigation = new HashSet<CartasPorte>();
            CartasPorteCpoUsuCodigoVendedorNavigation = new HashSet<CartasPorte>();
            SolicitudServicio = new HashSet<SolicitudServicio>();
            UsuarioActividad = new HashSet<UsuarioActividad>();
        }

        public int UsuId { get; set; }
        public string UsuNombre { get; set; }
        public string UsuCuit { get; set; }
        public string UsuNroContacto { get; set; }
        public string UsuMail { get; set; }
        public string UsuLocalidad { get; set; }
        public string UsuLogin { get; set; }
        public byte[] UsuPass { get; set; }
        public string UsuRol { get; set; }
        public string UsuEstado { get; set; }

        public virtual ICollection<CartasPorte> CartasPorteCpoUsuCodigoCompradorNavigation { get; set; }
        public virtual ICollection<CartasPorte> CartasPorteCpoUsuCodigoEntregadorNavigation { get; set; }
        public virtual ICollection<CartasPorte> CartasPorteCpoUsuCodigoVendedorNavigation { get; set; }
        public virtual ICollection<SolicitudServicio> SolicitudServicio { get; set; }
        public virtual ICollection<UsuarioActividad> UsuarioActividad { get; set; }
    }
}
