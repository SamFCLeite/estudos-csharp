using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OderSummary.Entites {
    class Client {
        // Properties
        public String name { get; set; }
        public String email { get; set; }
        public DateTime birthDate { get; set; }

        // Constructors
        public Client() {
        }

        public Client(string name, string email, DateTime birthDate) {
            this.name = name;
            this.email = email;
            this.birthDate = birthDate;
        }

        // Override ToString method PARA MOSTRAR INFORMAÇÕES DOCLIENTE
        public override string ToString() {
            return name + " " + birthDate.ToString("dd/MM/yyyy") + " - " + email;
        }
    }
}
