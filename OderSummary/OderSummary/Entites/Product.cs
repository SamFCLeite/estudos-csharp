using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OderSummary.Entites {
    internal class Product {
        // Properties
        public String name { get; set; }
        public double price { get; set; }
        //Constructors
        public Product()
        {
        }

        public Product(string name, double price) {
            this.name = name;
            this.price = price;
        }
    }
}
