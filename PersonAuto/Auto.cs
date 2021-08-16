using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAuto
{
    public class Auto
    {
        /// <summary>
        /// MArke des Autos
        /// </summary>
        public string Marke { get; set; }
        /// <summary>
        /// Kennzeichen des autos
        /// </summary>
        public string Kennzeichen { get; set; }

        /// <summary>
        /// Neues Leeres Auto
        /// </summary>
        public Auto()
        {

        }
        /// <summary>
        /// Auto mit Marke und Kennzeichen
        /// </summary>
        /// <param name="Marke">Marke string</param>
        /// <param name="Kennzeichen">Kennzeichen string</param>
        public Auto(string Marke, string Kennzeichen)
        {
            this.Marke = Marke;
            this.Kennzeichen = Kennzeichen;
        }


    }
}
