using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAuto
{
    public class Adresse
    {
        /// <summary>
        /// Strasse der Adresse
        /// </summary>
        public string Strasse { get; set; }
        /// <summary>
        /// Hausnummer der Adresse
        /// </summary>
        public string Hausnummer { get; set; }
        /// <summary>
        /// PLZ der Adresse
        /// </summary>
        public string Postleitzahl { get; set; }
        /// <summary>
        /// Ort der Adresse
        /// </summary>
        public string Ort { get; set; }
        /// <summary>
        /// Lader der Adresse
        /// </summary>
        public string Land { get; set; }

        /// <summary>
        /// neue leere Adresse
        /// </summary>
        public Adresse()
        {

        }
        /// <summary>
        /// Adresse mit strasse und Hausnummer
        /// </summary>
        /// <param name="Strasse">Strasse string</param>
        /// <param name="Hausnummer">Hausnummer String</param>
        public Adresse(string Strasse, string Hausnummer)
        {
            this.Strasse = Strasse;
            this.Hausnummer = Hausnummer;
        }





    }
}
