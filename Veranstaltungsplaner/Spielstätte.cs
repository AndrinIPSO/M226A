using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veranstaltungsplaner
{
    public class Spielstätte
    {
        public string Name { get; set; }

        public string Anschrift { get; set; }

        public Spielstätte()
        {

        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="Name">Veranstaltungsname</param>
        /// <param name="Anschrift">Lokation oder Adresse</param>
        public Spielstätte(string Name, string Anschrift)
        {
            this.Name = Name;
            this.Anschrift = Anschrift;
        }
    }
}
