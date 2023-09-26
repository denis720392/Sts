using System.Threading.Channels;
using System.Xml.Linq;
using WorkingWithProducts.Interfaces;

namespace WorkingWithProducts
{
    internal class WorkingWithProducts
    {
        static void Main(string[] args)
        {
            ProductVault vault = new ProductVault();
            vault.GetProducts();
        }
    }
}