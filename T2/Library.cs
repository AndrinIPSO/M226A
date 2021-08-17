using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    /// <summary>
    /// Bibliotheksklasse
    /// </summary>
    public class Library
    {
        /// <summary>
        /// Bibliotheksname
        /// </summary>
        public string LibraryName { get; set; }
        /// <summary>
        /// Anzahl angsetellte
        /// </summary>
        public int NumberOfEmployees { get; set; }
        /// <summary>
        /// Adresse
        /// </summary>
        public Address Address = new Address();
        /// <summary>
        /// Leere Bibliothek
        /// </summary>
        public Library()
        {

        }
        /// <summary>
        /// Bibliothek mit Anzahl angstellten und Name
        /// </summary>
        /// <param name="NumOfEmployees">Anzahl angsetellte</param>
        /// <param name="LibName">Name der Bibiothek</param>
        public Library(int NumOfEmployees, string LibName)
        {
            NumberOfEmployees = NumOfEmployees;
            LibraryName = LibName;
        }

        /// <summary>
        /// Büchergsetelle
        /// </summary>
        public List<Bookshelf> Bookshelf = new List<Bookshelf>();

        /// <summary>
        /// Büchergestell hinzufügen
        /// </summary>
        /// <param name="shelf"></param>
        public void addShelf(Bookshelf shelf)
        {
            Bookshelf.Add(shelf);
        }

        /// <summary>
        /// Büchergestelle anfordern
        /// </summary>
        /// <returns>Büchergestelle</returns>
        public List<Bookshelf> getBookshelvs()
        {
            return Bookshelf;
        }
    }
}
