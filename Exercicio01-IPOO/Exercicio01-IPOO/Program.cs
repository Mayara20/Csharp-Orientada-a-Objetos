using System;

namespace Exercicio01_IPOO {
    class Program {
        static void Main(string[] args) {

            Dados_Pessoal D1 = new Dados_Pessoal();
            Dados_Pessoal D2 = new Dados_Pessoal();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            D1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            D1.idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            D2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            D2.idade = int.Parse(Console.ReadLine());

            if (D1.idade > D2.idade) {
                Console.Write("Pessoa mais velha: " + D1.nome);
            }
            else {
                Console.Write("Pessoa mais velha: " + D2.nome);
            }
        }
    }
}
