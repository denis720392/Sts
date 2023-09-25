using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithProducts
{
    internal class Game : Product
    {
        public string date { get;}
        public int minAge { get;}
        public Game(string manufacturer, string name, double weight, double price, string description, string date, int minAge) : base(manufacturer, name, weight, price, description)
        {
            this.date = date;
            this.minAge = minAge;
            UnitOfMeasurement = UnitOfMeasurement.Gb;
        }

        override public string getInfo()
        {
            return
                GetType().Name + " ," +
                Manufacturer + " ," +
                Name + " ," +
                Weight + " " +
                UnitOfMeasurement + " ," +
                count + " ," +
                Price + " ," +
                date + " ," +
                minAge + " ," +
                Description + ";";
        }
    }
}
