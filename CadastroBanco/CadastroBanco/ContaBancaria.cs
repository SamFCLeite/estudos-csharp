using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroBanco {
    internal class ContaBancaria {
        //DADOS PRINCIPAIS
        public int NumeroConta {get; private set; } //PODE RECEBER VALOR, MAS NÃO PODE ALTERAR
        public String NomeUsuario { get; set; }
        public double Deposito { get; private set; } //PODE RECEBER VALOR, MAS NÃO PODE ALTERAR

        //MINIMO DE DADOS
        public ContaBancaria(int numeroConta, string nomeUsuario) {
            NumeroConta = numeroConta;
            NomeUsuario = nomeUsuario;
            Deposito = 0;
        }

        //TODOS OS DADOS
        public ContaBancaria(int numeroConta, string nomeUsuario, double deposito) { 
            NumeroConta = numeroConta;
            NomeUsuario = nomeUsuario;
            Deposito = deposito;
        }

        //FUNÇÕES DE DEPÓSITO E SAQUE
        public void Depositar(double valor) {
            if(valor < 0) {
                valor = 0;
            }
            Deposito += valor;
        }

        public void Sacar(double valor) {
            if(valor < 0) {
                valor = 0;
            }
            Deposito -= valor + 5.00;
        }

        //CONVERTENDO INFORMAÇÕES EM STRING PARA IMPRESSÃO
        public override string ToString() {
            return "Conta: " + NumeroConta + ", Titular: " + NomeUsuario + ", Saldo: R$ " + Deposito.ToString("F2");
        }

    }
}
