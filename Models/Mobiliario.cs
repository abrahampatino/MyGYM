using System;
using System.Collections.Generic;

namespace Proyectov1.Models
{
    public partial class Mobiliario
    {
        public int MobId { get; set; }
        public int ApaId { get; set; }
        public string MobApaNombre { get; set; }
        public bool? ApaEstatus { get; set; }

        public virtual Aparato Apa { get; set; }
    }
}
