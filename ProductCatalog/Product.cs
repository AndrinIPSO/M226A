using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog
{
    public class Product
    {

        public Product()
        {

        }

        public Product(float ProduktPreis, string ProduktName)
        {
            _Price = ProduktPreis;
            ProductName = ProduktName;
        }
        /// <summary>
        /// Produkt Name
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Private Price Var
        /// </summary>
        private float _Price;

        /// <summary>
        /// Neien Preis setzen
        /// </summary>
        /// <param name="newPrice">Neuer Preis</param>
        public void setPrice(float newPrice)
        {
            _Price = newPrice;
        }

        /// <summary>
        /// Preis erhalten
        /// </summary>
        /// <returns>Preis</returns>
        public float getPrice()
        {
            return _Price;
        }

    }
}
