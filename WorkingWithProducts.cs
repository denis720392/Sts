using System.Reflection.Metadata;
using System.Threading.Channels;
using System.Xml.Linq;
using WorkingWithProducts.Interfaces;

namespace WorkingWithProducts
{
    internal class WorkingWithProducts
    {
        static void Main(string[] args)
        {
            IReader readerCategory = new ReaderTextFile(Directory.GetCurrentDirectory() + "\\category.txt");
            IWriter writer = new WriteInFile(Directory.GetCurrentDirectory() + "\\products.txt", "Овощи;ауйуаууауууууу ; уууууу");
            Admin admin = new Admin();
            User user = new User();
            admin.AddProduct(writer);
            user.AddProduct(writer);
        }
    }
}