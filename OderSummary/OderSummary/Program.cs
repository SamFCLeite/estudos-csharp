using System;
using System.Collections.Generic;
using OderSummary.Entites;
using OderSummary.Entites.Enums;

namespace OderSummary {
    internal class Program {
        static void Main(string[] args) {
            //INFORMAÇÕES DO CLIENTE, PEDIDO E ITENS DO PEDIDO
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            //INFORMAÇÕES DO PEDIDO
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            //CRIANDO O CLIENTE E O PEDIDO
            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order?: ");
            int itemsCount = int.Parse(Console.ReadLine());

            //INFORMAÇÕES DOS ITENS DO PEDIDO
            for (int i = 0; i < itemsCount; i++) {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, productPrice, new Product(productName, productPrice));
                order.AddItem(orderItem);
            }

            //IMPRIMINDO O RESUMO DO PEDIDO, QUE FEZ, EMAIL, DATA DE NASCIMENTO, STATUS DO PEDIDO, ITENS DO PEDIDO E TOTAL DO PEDIDO
            Console.WriteLine(order);
        }
    }
}