using System;
using System.Collections.Generic;

namespace Proyectov1.Models
{
    public partial class Aparato
    {
        public Aparato()
        {
            Mobiliario = new HashSet<Mobiliario>();
        }

        public int ApaId { get; set; }
        public string ApaNombre { get; set; }
        public string ApaDescripcion { get; set; }

        public virtual ICollection<Mobiliario> Mobiliario { get; set; }
    }
}
