using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithProducts
{
    internal interface IProduct
    {
        public Guid Guid { get;}
        public string getInfo();
    }
}
