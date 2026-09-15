using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceTags.Entities {
    internal class ImportedProduct : Product {
        //ATRIBUTOS + ATRIBUTO DE ACESSO
        public double customFree { get; set; }

        //CONSTRUTORES
        public ImportedProduct() {
        }

        public ImportedProduct(string name, double price, double customFree) 
            : base(name, price) {
            this.customFree = customFree;
        }

        //METODO PARA CALCULAR O PREÇO TOTAL DO PRODUTO IMPORTADO
        public double totalPrice() {
            return price + customFree;
        }

        //MÉTODO SOBRESCRITO PARA MOSTRAR A ETIQUETA DE PREÇO DO PRODUTO IMPORTADO
        public override string PriceTag() {
            price = totalPrice();
            return $"{name} $ {price:F2} (Customs fee: $ {customFree:F2})";
        }
    }
}
