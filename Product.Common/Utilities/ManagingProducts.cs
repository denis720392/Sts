
using Sts.Product.Common.Interfaces;

namespace Sts.Product.Common.Utilities
{
    public abstract class ManagingProducts : IUsualPermission
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
