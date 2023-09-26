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
        virtual public void AddProduct()
        {
            Console.WriteLine(GetType().Name + " " + "Добавил продукт");
        }

        virtual public void DeleteProduct()
        {
            Console.WriteLine(GetType().Name + " " + "Удалил продукт");
        }

        virtual public void EditProduct()
        {
            Console.WriteLine(GetType().Name + " " + "Изменил продукт");
        }

        virtual public void AddCategoryProduct()
        {
            Console.WriteLine(GetType().Name + " " + "Добавил категорию продукта");
        }

        virtual public void DeleteCategoryProduct()
        {
            Console.WriteLine(GetType().Name + " " + "Удалил категорию продукта");
        }

        virtual public void EditCategoryProduct()
        {
            Console.WriteLine(GetType().Name + " " + "Изменил категорию продукта");
        }
    }
}
