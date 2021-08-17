using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogWPF
{
    public class Catalog
    {
        /// <summary>
        /// ProductList
        /// </summary>
        public List<Product> ListOfProducts = new List<Product>();

        /// <summary>
        /// Produkt Hinzufügen
        /// </summary>
        /// <param name="Item">Produkt</param>
        public void AddItem(Product Item)
        {
            ListOfProducts.Add(Item);
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public Catalog()
        {

        }


    }
}
