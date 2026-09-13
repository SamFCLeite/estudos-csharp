using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OderSummary.Entites.Enums;

namespace OderSummary.Entites {
    class Order {
        // Properties
        public DateTime Date { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public Client client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();


        // Constructors
        public Order()
        {
        }

        public Order(DateTime date, OrderStatus status, Client client) {
            Date = date;
            Status = status;
            this.client = client;
        }

        // Methods
        public void AddItem(OrderItem item) {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            Items.Remove(item);
        }

        public double Total() {
            double total = 0.0;
            foreach (var item in Items) {
                total += item.subTotal();
            }
            return total;
        }

        // Override ToString method PARA MOSTRAR SUMARIO DE PEDIDO
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Summary:");
            sb.AppendLine("Order moment: " + Date);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + client);
            sb.AppendLine("Order Items:");
            foreach (var item in Items) {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total());
            return sb.ToString();
        }
    }
}
