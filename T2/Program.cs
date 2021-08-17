using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bibliothek instanziieren
            Library lib1 = new Library(12, "ZentrumsBibliothek");

            // Bücherregale instanziiren
            lib1.Bookshelf.Add(new Bookshelf(1, 2));
            lib1.Bookshelf.Add(new Bookshelf(2, 2));


            // Bücher instanziieren und in Bücherregal hinzufügen
            lib1.Bookshelf[0].Book.Add(new Book("1231", "Der Hund und sein Vater", "61661116161"));
            lib1.Bookshelf[0].Book.Add(new Book("1241", "Der Vater und sein Hund", "61111116161"));
            lib1.Bookshelf[1].Book.Add(new Book("1251", "Die Tochter und die Katze", "66661116161"));
            lib1.Bookshelf[1].Book.Add(new Book("1261", "Die Katze und die Tochter", "61611116161"));

            // Adresse modifiziren
            lib1.Address.City = "Aargau";
            lib1.Address.Country = "Schweiz";
            lib1.Address.Location = "Aargau";
            lib1.Address.PostalCode = 8965;
            lib1.Address.Street = "Bahnhofstrasse 12";

            // Durchlaufen der Büchergestelle in der Bibliothek um Bücher auszugeben
            int i = 1;
            foreach (Bookshelf bookshelf in lib1.Bookshelf)
            {
                Console.WriteLine("---Büchergestell {0}", i);
                foreach (Book book in bookshelf.Book)
                {
                    Console.WriteLine(" ISBN:    {0}", book.ISBN);
                    Console.WriteLine(" Titel:   {0}", book.Title);
                    Console.WriteLine(" Barcode: {0}", book.Barcode);
                }
                i++;
            }

            Console.Read();
        }
    }
}
