﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithProducts.Interfaces
{
    internal interface IUsualPermission
    {
        public void AddProduct(IWriter writer);
        public void DeleteProduct(IReader reader);
        public void EditProduct();
    }
}
