using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithProducts.Interfaces
{
    internal interface IAdminPermission
    {
        public void AddCategoryProduct(IWriter writer);
        public void DeleteCategoryProduct(IReader reader);
        public void EditCategoryProduct();
    }
}
