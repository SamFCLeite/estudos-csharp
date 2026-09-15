using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceTags.Entities {
    internal class UsedProduct : Product {
        //ATRIBUTOS + ATRIBUTO DE ACESSO
        public DateTime manufactureDate { get; set; }

        //CONSTRUTORES
        public UsedProduct() {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
           : base(name, price) {
            this.manufactureDate = manufactureDate;
        }


        //MÉTODO SOBRESCRITO PARA MOSTRAR A ETIQUETA DE PREÇO DO PRODUTO USADO
        public override string PriceTag() {
            return $"{name} (used) $ {price:F2} (Manufacture date: {manufactureDate:dd/MM/yyyy})";
        }
    }
}
