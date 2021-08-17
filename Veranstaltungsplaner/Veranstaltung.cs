using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veranstaltungsplaner
{
    public class Veranstaltung
    {
        public string Name { get; set; }
        public double Datum { get; set; }
        public double Zeit { get; set; }

        /// <summary>
        /// Ctor
        /// </summary>
        public Veranstaltung()
        {

        }
        /// <summary>
        /// Ctor with information
        /// </summary>
        /// <param name="n">Name of se Veranstaltung</param>
        /// <param name="dat">Date of the Veranstaltung</param>
        /// <param name="time">Zeit der Veranstaltung</param>
        public Veranstaltung(string n, double dat, double time)
        {
            Name = n;
            Datum = dat;
            Zeit = time;
        }
    }
}
