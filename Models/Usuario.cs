using System;
using System.Collections.Generic;

namespace Proyectov1.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Persona = new HashSet<Persona>();
            Rol = new HashSet<Rol>();
        }

        public int UsuId { get; set; }
        public string UsuName { get; set; }

        public string UsuCorr { get; set; }
        public string UsuPass { get; set; }

        public virtual ICollection<Persona> Persona { get; set; }
        public virtual ICollection<Rol> Rol { get; set; }
    }
}
