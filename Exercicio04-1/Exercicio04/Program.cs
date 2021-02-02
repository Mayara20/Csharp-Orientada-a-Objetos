using System;
using System.Globalization;

namespace Exercicio04 {
    class Program {
        static void Main(string[] args) {

              int numerofuncionario = int.Parse(Console.ReadLine());
            int horastrabalhadas = int.Parse(Console.ReadLine());
            double salariohora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horastrabalhadas * salariohora;

            Console.WriteLine("NUMBER = " + numerofuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
