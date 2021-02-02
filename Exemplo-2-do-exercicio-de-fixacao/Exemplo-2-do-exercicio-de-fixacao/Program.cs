using System;
using System.Globalization;

namespace Exemplo_2_do_exercicio_de_fixacao {
    class Program {
        static void Main(string[] args) {

            DadosBancarios Dados;

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string Nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.Write("Entre com o valor de depósito inicial: ");
                double Saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Dados = new DadosBancarios(conta, Nome, Saldo);
            }
            else {
                Dados = new DadosBancarios(conta, Nome);
            }
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(Dados);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Dados.deposito(saldo);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(Dados);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Dados.saque(saldo); 
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(Dados);

        }
    }
}
