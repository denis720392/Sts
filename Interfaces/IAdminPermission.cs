using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithProducts.Interfaces
{
    internal interface IAdminPermission
    {
        public void AddCategoryProduct();
        public void DeleteCategoryProduct();
        public void EditCategoryProduct();
    }
}
