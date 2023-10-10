
namespace Sts.Product.Common.Interfaces
{
    public interface IUsualPermission
    {
        public void AddProduct(IWriter writer);
        public void DeleteProduct(IReader reader);
        public void EditProduct();
    }
}
