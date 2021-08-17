using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veranstaltungsplaner
{
    public class Platz
    {
        public int Reihe { get; set; }
        public int Nummer { get; set; }

        public Platz()
        {

        }

        public Platz(int reihe, int nummer)
            :this()
        {
            this.Reihe = reihe;
            this.Nummer = nummer;
        }
        public string Bestätigt()
        {
            return "YESSIR";
        }
    }
}
