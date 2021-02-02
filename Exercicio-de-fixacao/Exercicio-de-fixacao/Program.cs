using System;
using System.Globalization;

namespace Exercicio_de_fixacao {
    class Program {
        static void Main(string[] args) {

            DadosDaConta Dados;

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char Resp = char.Parse(Console.ReadLine());
            if (Resp == 'S' || Resp == 's') {
                Console.Write("Entre o valor de depósito inicial: ");
                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Dados = new DadosDaConta(conta, nomeTitular, valorInicial);
            }
            else {
                Dados = new DadosDaConta(conta, nomeTitular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(Dados);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Dados.deposito(valorDeposito);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(Dados);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Dados.saque(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(Dados);

            

        }
    }
}
