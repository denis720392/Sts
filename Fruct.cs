using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithProducts
{
    internal class Fruct : Product
    {
        public Fruct(string manufacturer, string name, double weight, double price, string description) : base(manufacturer, name, weight, price, description)
        {
            UnitOfMeasurement = UnitOfMeasurement.kg;
        }
    }
}
