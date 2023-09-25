
namespace WorkingWithProducts
{
    abstract internal class Product : IProduct
    {
        public Guid Guid { get; }
        public string Name { get; }
        public double Weight { get; }

        public string Description { get;}
        public string Manufacturer { get;}
        public double Price { get;}
        protected UnitOfMeasurement UnitOfMeasurement;
        public readonly int count = 1;
        public Product(string manufacturer, string name, double weight, double price, string description)
        {
            Name = name;
            Weight = weight;
            Description = description;
            Manufacturer = manufacturer;
            Price = price;
            Guid = Guid.NewGuid();
        }

        virtual public string getInfo()
        {
            return
                GetType().Name + " ," +
                Manufacturer + " ," +
                Name + " ," +
                Weight + " " +
                UnitOfMeasurement + " ," +
                count + " ," +
                Price + " ," +
                Description + ";";
        }
    }
}
