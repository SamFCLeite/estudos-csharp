using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceTags.Entities {
    internal class Product {
        //ATRIBUTOS
        public String name { get; set; }
        public double price { get; set; }

        //CONSTRUTORES
        public Product() {

        }

        public Product(string name, double price) {
            this.name = name;
            this.price = price;
        }

        //MÉTODO VIRTUAL PARA SER SOBRESCRITO NAS CLASSES FILHAS
        public virtual string PriceTag() {
            return $"{name} $ {price:F2}";
        }
    }
}
