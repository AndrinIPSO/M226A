using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    /// <summary>
    /// Büchergestell Klasse
    /// </summary>
    public class Bookshelf
    {
        /// <summary>
        /// Nummer
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// Anzahl Büchergestelle
        /// </summary>
        public int NumOfShelfs { get; set; }

        /// <summary>
        /// Leerer Privater Konstruktor
        /// </summary>
        private Bookshelf()
        {

        }
        /// <summary>
        /// Büchergestell mit Nummer und Anzahl Büchergestelle
        /// </summary>
        /// <param name="No">Nummer setzen</param>
        /// <param name="NumOfBookshelfs">Anzahl Büchergsetelle setzen</param>
        public Bookshelf(int No, int NumOfBookshelfs)
        {
            this.No = No;
            this.NumOfShelfs = NumOfShelfs;
        }

        /// <summary>
        /// Clearen
        /// </summary>
        public void Clear()
        {

        }

        /// <summary>
        /// Bücher
        /// </summary>
        public List<Book> Book = new List<Book>();
    }
}
