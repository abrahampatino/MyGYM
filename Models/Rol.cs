using System;
using System.Collections.Generic;

namespace Proyectov1.Models
{
    public partial class Rol
    {
        public int RolId { get; set; }
        public int UsuId { get; set; }
        public bool? RolAdmin { get; set; }
        public bool? RolEmployee { get; set; }
        public bool? RolSocio { get; set; }

        public virtual Usuario Usu { get; set; }
    }
}
