using System;

namespace CadastroBanco {
    internal class Program {
        static void EscreverDadosConta(ContaBancaria usuario) {
            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(usuario);
        }
        static void Main(string[] args) {
            ContaBancaria usuario;

            //ENTRANDO COM OS DADOS DO USUÁRIO
            Console.Write("Entre o número da conta: ");
            int NumeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o nome do titular: ");
            String NomeUsuario = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?: ");
            String resposta = Console.ReadLine();
            if(resposta == "s") {
                Console.Write("Entre o valor de depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine());
                usuario = new ContaBancaria(NumeroConta, NomeUsuario, deposito);
            } else {
                usuario = new ContaBancaria(NumeroConta, NomeUsuario);
            }

            //ESCREVENDO OS DADOS DA CONTA
            EscreverDadosConta(usuario);

            //DEPÓSITO
            Console.WriteLine();
            Console.WriteLine("Entre um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            usuario.Depositar(valorDeposito);

            //ESCREVENDO OS DADOS DA CONTA APÓS O DEPÓSITO
            EscreverDadosConta(usuario);

            //SAQUE
            Console.WriteLine();
            Console.WriteLine("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine());
            usuario.Sacar(valorSaque);

            //ESCREVENDO OS DADOS DA CONTA APÓS O SAQUE
            //teste
            EscreverDadosConta(usuario);
        }
    }
}