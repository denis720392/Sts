using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingWithProducts.Interfaces;

namespace WorkingWithProducts
{
    internal class Admin : ManagingProducts, IAdminPermission , IUsualPermission 
    {
        public void AddCategoryProduct(IWriter writer)
        {
            Console.WriteLine(GetType().Name + " добавил категорию продукта");
            writer.Write();
        }

        public void DeleteCategoryProduct(IReader reader)
        {
            Console.WriteLine(GetType().Name + " удалил категорию продукта");
            reader.Read();
        }

        public void EditCategoryProduct()
        {
            Console.WriteLine(GetType().Name + " изменил категорию продукта");
        }
    }
}
