using System.Globalization;
using Course;
namespace Course {
    class Produto {
        private string _nome; //atributo privativo
        public double Preco { get; private set; } //Propriedades autoimplementadas
        public double Quantidade { get; set; }//Propriedades autoimplementadas
        public Produto() { //Construtores
        }
        public Produto(string nome, double preco, int quantidade) { //Construtores
            _nome = nome; //Construtores
            Preco = preco; //Construtores
            Quantidade = quantidade; //Construtores
        }
        public string Nome { //Propriedades Customizadas
            get { return _nome; }//Propriedades Customizadas
            set {//Propriedades Customizadas
                if (value != null && value.Length > 1) {//Propriedades Customizadas
                    _nome = value;//Propriedades Customizadas
                }//Propriedades Customizadas
            }//Propriedades Customizadas
        }//Propriedades Customizadas
        public double ValorTotalEmEstoque { //Outros métodos da classe
            get { return Preco * Quantidade; }//Outros métodos da classe
        }//Outros métodos da classe
        public void AdicionarProdutos(int quantidade) {//Outros métodos da classe
            Quantidade += quantidade;//Outros métodos da classe
        }
        public void RemoverProdutos(int quantidade) {//Outros métodos da classe
            Quantidade -= quantidade;//Outros métodos da classe
        }
        public override string ToString() {//Outros métodos da classe
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}