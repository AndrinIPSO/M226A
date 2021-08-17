using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog Katalog = new Catalog();
            Katalog.AddItem(new Product(113, "Guccibelt"));
            Katalog.AddItem(new Product(3.5f, "Eine dings"));
            Katalog.AddItem(new Product(666, "Flugi"));

            foreach (Product produkt in Katalog.ListOfProducts)
            {
                Console.WriteLine("Prödüct name: {0}", produkt.ProductName);
                Console.WriteLine("Preis: CHF {0}", produkt.getPrice());
            }
            Console.Read();
        }
    }
}
