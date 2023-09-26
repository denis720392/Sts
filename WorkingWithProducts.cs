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
            Admin admin = new Admin();
            User user = new User();
            admin.AddProduct();
            user.AddProduct();
            admin.AddCategoryProduct();
        }
    }
}