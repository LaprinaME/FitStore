using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitStore
{
    public static class ProductRepository
    {
        public static List<Product> Products { get; set; } = new List<Product>();

        static ProductRepository()
        {
            // Инициализация списка товаров
            Products.Add(new Product { ArticleNumber = "001", Name = "Стиральный порошок", Description = "Порошок для стирки одежды", Category = "Бытовая химия", Manufacturer = "ЧистоДом", Cost = 100, QuantityInStock = 10, Status = "Доступен" });
            Products.Add(new Product { ArticleNumber = "002", Name = "Средство для мытья посуды", Description = "Жидкость для посуды", Category = "Бытовая химия", Manufacturer = "ЭкоМир", Cost = 200, QuantityInStock = 0, Status = "Недоступен" });
            Products.Add(new Product { ArticleNumber = "003", Name = "Смартфон", Description = "Современный смартфон", Category = "Электроника", Manufacturer = "ТехноМир", Cost = 15000, QuantityInStock = 15, Status = "Доступен" });
            Products.Add(new Product { ArticleNumber = "004", Name = "Наушники", Description = "Беспроводные наушники", Category = "Аксессуары", Manufacturer = "ЗвукПро", Cost = 3000, QuantityInStock = 25, Status = "Доступен" });
            Products.Add(new Product { ArticleNumber = "005", Name = "Ноутбук", Description = "Игровой ноутбук", Category = "Компьютеры", Manufacturer = "ЭлектроКомп", Cost = 45000, QuantityInStock = 5, Status = "Доступен" });
            Products.Add(new Product { ArticleNumber = "006", Name = "Смарт-часы", Description = "Умные часы с пульсометром", Category = "Электроника", Manufacturer = "ТаймТех", Cost = 8000, QuantityInStock = 20, Status = "Доступен" });
            Products.Add(new Product { ArticleNumber = "007", Name = "Телевизор", Description = "4K телевизор", Category = "Электроника", Manufacturer = "ВижнТек", Cost = 25000, QuantityInStock = 7, Status = "Доступен" });
            Products.Add(new Product { ArticleNumber = "008", Name = "Планшет", Description = "Планшет для учебы", Category = "Компьютеры", Manufacturer = "УчТек", Cost = 12000, QuantityInStock = 12, Status = "Доступен" });
            Products.Add(new Product { ArticleNumber = "009", Name = "Клавиатура", Description = "Механическая клавиатура", Category = "Аксессуары", Manufacturer = "КейбордПро", Cost = 2500, QuantityInStock = 30, Status = "Доступен" });
            Products.Add(new Product { ArticleNumber = "010", Name = "Мышь", Description = "Игровая мышь", Category = "Аксессуары", Manufacturer = "МышПро", Cost = 1500, QuantityInStock = 40, Status = "Доступен" });
            Products.Add(new Product { ArticleNumber = "011", Name = "Колонка", Description = "Беспроводная колонка", Category = "Аудио", Manufacturer = "ЗвукВолна", Cost = 3500, QuantityInStock = 18, Status = "Доступен" });
            Products.Add(new Product { ArticleNumber = "012", Name = "Монитор", Description = "HD монитор", Category = "Компьютеры", Manufacturer = "МонПро", Cost = 9000, QuantityInStock = 8, Status = "Доступен" });
        }

    }

}
