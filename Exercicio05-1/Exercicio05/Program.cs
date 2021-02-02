using System;
using System.Globalization;

namespace Exercicio05 {
    class Program {
        static void Main(string[] args) {

            string[] vet = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(vet[0]);
            int quant1 = int.Parse(vet[1]);
            double valor1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(vet[0]);
            int quant2 = int.Parse(vet[1]);
            double valor2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double preco = valor1 * quant1 + valor2 * quant2;

            Console.WriteLine("VALOR A PAGAR: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
