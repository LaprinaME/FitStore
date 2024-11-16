using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitStore
{
    // Класс для склада
    public class Warehouse
    {
        public string WarehouseName { get; set; }
        public List<Product> Products { get; set; }

        public Warehouse()
        {
            Products = new List<Product>();
        }

        // Метод для добавления товара на склад
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        // Метод для получения всех доступных товаров
        public List<Product> GetAvailableProducts()
        {
            return Products.Where(p => p.QuantityInStock > 0).ToList();
        }
    }
}
