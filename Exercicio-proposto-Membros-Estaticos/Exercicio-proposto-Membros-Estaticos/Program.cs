using System;
using System.Globalization;

namespace Exercicio_proposto_Membros_Estaticos {
    class Program {
        static void Main(string[] args) {

            Produto X = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            X.nome = Console.ReadLine();
            Console.Write("Preço: ");
            X.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            X.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + X);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: "); 
            int qte = int.Parse(Console.ReadLine());
            X.adicionarProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + X);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: " );
            qte = int.Parse(Console.ReadLine());
            X.removerProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + X);
            



        }
    }
}
