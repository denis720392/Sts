using System.Threading.Channels;
using System.Xml.Linq;

namespace WorkingWithProducts
{
    internal class General
    {
        static void Main(string[] args)
        {
            ProductVault vault = new ProductVault();
            Vegetable product = new Vegetable("ООО \"Овощи\"", "Огурец", 2.0, 100, "Свежий огурец");
            IProduct product1 = new Vegetable("ООО \"Овощи\"", "Помидор", 2.0, 100, "Свежий помидор");
            IProduct product2 = new Vegetable("ООО \"Овощи\"", "Кабачок", 1.0, 50, "Свежий кабачок");
            IProduct product3 = new Game("Электроник артс", "COD", 108,1200, "Шутер от 1 лица, война 21 век", "12.12.2003", 18);
            Product product4 = new Fruct("ООО Фрукты", "Манго", 1, 750, "Сушеный манго без добавления сахара");
            vault.AddProduct(product);
            vault.AddProduct(product1);
            vault.AddProduct(product2);
            vault.AddProduct(product3);
            vault.AddProduct(product4);
            vault.GetProducts();
        }
    }
}