using System;
using System.Collections.Generic;
using PriceTags.Entities;

namespace PriceTags {
    internal class Program {
        static void Main(string[] args) {
            //CRIANDO LISTA DE PRODUTOS
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            //LENDO DADOS DE CADA PRODUTO
            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Product #{i} data: ");

                Console.Write("Common, used or imported (c/u/i)?: ");

                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                switch (type) {
                    case 'c':
                        products.Add(new Product(name, price));
                        break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, manufactureDate));
                        break;

                    case 'i':
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine());
                        products.Add(new ImportedProduct(name, price, customsFee));
                        break;
                }

            }

            //MOSTRANDO AS ETIQUETAS DE PREÇO
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach(Product product in products) {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}