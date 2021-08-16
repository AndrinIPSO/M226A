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
        public string Vorname { get; set; }
        public string Nachnme { get; set; }
        public int Alter { get; set; }
        public DateTime GeburtsDatum { get; set; }

        public Person(string vorname, string nachname)
        {
            this.Vorname = vorname;
            this.Nachnme = nachname;
        }


    }
}
