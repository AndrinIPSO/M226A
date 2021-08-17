using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    /// <summary>
    /// Bücher Klasse
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Barcode
        /// </summary>
        public string Barcode { get; set; }
        /// <summary>
        /// ISBN
        /// </summary>
        public string ISBN { get; set; }
        /// <summary>
        /// Titel
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Hardcover
        /// </summary>
        protected bool Hardcover;
        /// <summary>
        /// Seitenanzahl
        /// </summary>
        protected int Pages;
        /// <summary>
        /// Leerer, privater Konstruktor
        /// </summary>
        private Book()
        {

        }
        /// <summary>
        /// Buch Instanziieren mit ISBN und Titel
        /// </summary>
        /// <param name="ISBN">ISBN hinzufügen</param>
        /// <param name="Title">Titel hinzufügen</param>
        public Book(string ISBN, string Title)
        {
            this.Title = Title;
            this.ISBN = ISBN;
        }
        /// <summary>
        /// Buch Instanziieren mit ISBN, Titel und Barcode
        /// </summary>
        /// <param name="ISBN"></param>
        /// <param name="Title"></param>
        /// <param name="Barcode"></param>
        public Book(string ISBN, string Title, string Barcode)
        {
            this.Title = Title;
            this.ISBN = ISBN;
            this.Barcode = Barcode;
        }
        /// <summary>
        /// Auslehn Methode
        /// </summary>
        /// <returns>true wenn ausgelehnt</returns>
        public bool isBorrowed()
        {
            return true;
        }
        /// <summary>
        /// Festlegen ob Hardcoveroder nicht
        /// </summary>
        /// <param name="hc">Hardcover</param>
        public void setHardcover(bool hc)
        {
            Hardcover = hc;
        }
        /// <summary>
        /// Anzahl seiten festlegen
        /// </summary>
        /// <param name="Pages">Seitenanzahl</param>
        public void setPages(int Pages)
        {
            this.Pages = Pages;
        }
    }
}
