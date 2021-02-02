using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {

           
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            //console.writeLine(p.GetNome());   usável no modo privativo
            //p.setNome("TV 4K");        caso escolha outro nome
            Produto p = new Produto(nome, preco, quantidade);
            // Produto p = new Produto(nome, preco); construtor
            // Produto p2 = new Produto();
            // Produto p3 = new Produto {Nome = "TV", Preco = 900.00, Quantidade = 20}; 
            // Instanciar Produto 


            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}