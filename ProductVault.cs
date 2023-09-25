using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithProducts
{
    internal class ProductVault
    {
        private Dictionary<Guid, string> dictionary = new Dictionary<Guid, string>();

        public Dictionary<Guid, string> AddProduct(IProduct product) 
        {
            dictionary.Add(product.Guid, product.getInfo());
            return dictionary;
        }

        public void GetProducts() 
        {
            foreach (var product in dictionary) 
            {
                Console.WriteLine(product.Key + " " + product.Value);
            }
        }
    }
}
