using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAuto
{
    /// <summary>
    /// Person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Vorname der Person
        /// </summary>
        public string Vorname { get; set; }
        /// <summary>
        /// NAchname der Person
        /// </summary>
        public string Nachname { get; set; }
        /// <summary>
        /// Alter der Person
        /// </summary>
        public int Alter { get; set; }
        /// <summary>
        /// Geburtsdatum der Person
        /// </summary>
        public DateTime GeburtsDatum { get; set; }

        /// <summary>
        /// Leerer Konstruktor
        /// </summary>
        public Person()
        {

        }
        /// <summary>
        /// Person mit Vorname und Name
        /// </summary>
        /// <param name="vorname">Vorname der Person</param>
        /// <param name="nachname">Nachname der Person</param>
        public Person(string vorname, string nachname)
            : this()
        {
            this.Vorname = vorname;
            this.Nachname = nachname;
        }

        /// <summary>
        /// Adresse der Person
        /// </summary>
        public Adresse Hauptwohnsitz { get; set; } = new Adresse();
        /// <summary>
        /// Auto(s) der Person
        /// </summary>
        public List<Auto> Autos { get; set; } = new List<Auto>();
    }
}
