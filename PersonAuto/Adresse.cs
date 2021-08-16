using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAuto
{
    public class Adresse
    {
        public string Strasse { get; set; }
        public string Hausnummer { get; set; }
        public string Postleitzahl { get; set; }
        public string Ort { get; set; }
        public string Land { get; set; }

        public Adresse(string Strasse, string Hausnummer)
        {
            this.Strasse = Strasse;
            this.Hausnummer = Hausnummer;
        }





    }
}
