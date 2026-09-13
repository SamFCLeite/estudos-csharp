using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OderSummary.Entites {
    internal class OrderItem {
        public double quantity { get; set; }
        public double price { get; set; }
        public Product product { get; set; }

        public OrderItem() { }

        public OrderItem(double quantity, double price, Product product) {
            this.quantity = quantity;
            this.price = price;
            this.product = product;
        }

        public double subTotal() {
            return quantity * price;
        }

        override public string ToString() {
            return $"{product.name}, ${price}, Quantity: {quantity}, Subtotal: ${subTotal()}";
        }
    }
}
