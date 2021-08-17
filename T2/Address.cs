using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    /// <summary>
    /// Adress Klasse
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Stadt 
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Land 
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Ort 
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// Postleitzahl 
        /// </summary>
        public int PostalCode { get; set; }
        /// <summary>
        /// Strasse
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Leere Adresse erstellen
        /// </summary>
        public Address()
        {

        }

        /// <summary>
        /// Adresse mit PLZ und Stadt erstellen
        /// </summary>
        /// <param name="postalcode">Postleitzahl setzen</param>
        /// <param name="city">Stadt setzen</param>
        public Address(int postalcode, string city)
        {
            PostalCode = postalcode;
            City = city;
        }

    }
}
