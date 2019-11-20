using System;
using System.Collections.Generic;

namespace Proyectov1.Models
{
    public partial class Persona
    {
        public Persona()
        {
            Usu = new Usuario();
        }
        public int PerId { get; set; }
        public string PerNombre { get; set; }
        public string PerNombre2 { get; set; }
        public string PerPaterno { get; set; }
        public string PerMaterno { get; set; }
        public string PerTipo { get; set; }
        public int UsuId { get; set; }
        public string SocTelefono { get; set; }
        public double? SocPeso { get; set; }
        public double? SocAltura { get; set; }
        public string EmpRfc { get; set; }
        public string EmpImss { get; set; }
        public int? InsoInst { get; set; }

        public bool? PerEstado { get; set; }

        public virtual Usuario Usu { get; set; }
    }
}
