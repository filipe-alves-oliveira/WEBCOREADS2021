using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBCOREADS2021.Models.Dominio
{
    public class Premiacao
    {
        public int id { get; set; }
        public int colocacao { get; set; }
        public Pescador pescador { get; set; }
        public string premio { get; set; }

        public ICollection<Pescador> nome { get; set; }
    }
}
