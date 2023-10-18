//Гордеева Иванова 221
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

//Здесь мы создали класс Product с нужными нам полями
public class Product
{
    public double Weight { get; set; }
    public decimal Price { get; set; }
    public double Volume { get; set; }
    public string Name { get; set; }
    public bool IsFragile { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        //в методе Main создали список, добавили 10 продуктов
        List<Product> products = new List<Product>
        {
            new Product { Weight = 1.5, Price = 10.99m, Volume = 0.5, Name = "Product 1", IsFragile = true },
            new Product { Weight = 2.0, Price = 19.99m, Volume = 0.8, Name = "Product 2", IsFragile = false },
            new Product { Weight = 3.0, Price = 20.00m, Volume = 0.9, Name = "Product 3", IsFragile = false },
            new Product { Weight = 4.0, Price = 28.00m, Volume = 0.1, Name = "Product 4", IsFragile = true },
            new Product { Weight = 7.0, Price = 31.00m, Volume = 1.0, Name = "Product 5", IsFragile = true },
            new Product { Weight = 10.0, Price = 150.00m, Volume = 6.0, Name = "Product 6", IsFragile = false },
            new Product { Weight = 9.7, Price = 237.00m, Volume = 31.0, Name = "Product 7", IsFragile = false },
            new Product { Weight = 1.0, Price = 13.99m, Volume = 0.3, Name = "Product 8", IsFragile = true },
            new Product { Weight = 15.5, Price = 567.79m, Volume = 42.0, Name = "Product 9", IsFragile = false },
            new Product { Weight = 3.5, Price = 11.00m, Volume = 1.5, Name = "Product 10", IsFragile = true },
        };

        // Проводим сортировку по весу от большего к меньшему
        products = products.OrderByDescending(p => p.Weight).ToList();
        Console.WriteLine("Sorted by Weight:");

        // Здесь мы выводим список продуктов
        foreach (Product product in products)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, IsFragile: {product.IsFragile}");
        }

        // Преобразовываем список в JSON
        string json = JsonConvert.SerializeObject(products, Formatting.Indented);

        // Выводим в JSON
        Console.WriteLine($"JSON: {json}");
    }
}
//Мы писали комментарии специально для вас, чтобы вы поняли, что мы начинаем шарить в программировании!!!!!!!
//Надеемся, что вы искренне рады за нас<3
