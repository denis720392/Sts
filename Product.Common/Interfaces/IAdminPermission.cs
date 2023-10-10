
namespace Sts.Product.Common.Interfaces
{
    public interface IAdminPermission
    {
        public void AddCategoryProduct(IWriter writer);
        public void DeleteCategoryProduct(IReader reader);
        public void EditCategoryProduct();
    }
}
