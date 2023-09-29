using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingWithProducts.Interfaces;

namespace WorkingWithProducts
{
    abstract class ManagingProducts
    {
        virtual public void AddProduct(IWriter writer)
        {
            Console.WriteLine(GetType().Name + " добавил продукт");
            writer.Write();
        }

        virtual public void DeleteProduct(IReader reader)
        {
            Console.WriteLine(GetType().Name + " удалил продукт");
            reader.Read();
        }

        virtual public void EditProduct()
        {
            Console.WriteLine(GetType().Name + " изменил продукт");
        }
    }
}
