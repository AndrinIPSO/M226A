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

        public Saalplan gehört { get; set; } = new Saalplan();

        public string Bestätigt()
        {
            return "YESSIR";
        }
    }
}
