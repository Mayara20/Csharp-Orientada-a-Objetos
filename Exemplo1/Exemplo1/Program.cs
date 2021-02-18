using System;

namespace Exemplo1 {
    class Program {
        static void Main(string[] args)
        {
			Carro civic = new Carro("preto","Honda Civic", 4, 85250.00);
			Carro up = new Carro("branco", "Up", 2, 20000.50);

			/*Console.Write("Digite o Modelo do carro: ");
            string modelo = Console.ReadLine();
			Console.Write("Quantidade de portas: ");
            int portas = int.Parse(Console.ReadLine());
            //double valor = double.Parse(Console.ReadLine());

            Carro civic = new Carro(modelo,portas); */

            civic.TrocarCor("vermelho");

            Console.WriteLine("Antes de desconto");
            Console.WriteLine("Modelo: " + civic.Modelo);
            Console.WriteLine("Cor: " + civic.Cor);
            Console.WriteLine("Quantidade de portas: " + civic.Portas);
            Console.WriteLine("valor: $" + civic.Valor);
            Console.WriteLine();

            civic.AplicarDesconto(10000);

            Console.WriteLine("Após desconto" );
            Console.WriteLine("Modelo: " + civic.Modelo);
            Console.WriteLine("Cor: " + civic.Cor);
            Console.WriteLine("Quantidade de portas: " + civic.Portas);
            Console.WriteLine("valor: $" + civic.Valor);

            Console.ReadLine();
        }
    }
}
