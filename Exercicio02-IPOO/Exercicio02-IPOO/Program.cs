using System;
using System.Globalization;

namespace Exercicio02_IPOO {
    class Program {
        static void Main(string[] args) {

            Funcionarios N1 = new Funcionarios();
            Funcionarios N2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            N1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            N1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            N2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            N2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Media = (N1.salario + N2.salario) / 2.0;
            Console.Write("Salário médio = " + Media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
