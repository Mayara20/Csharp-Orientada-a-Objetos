using System.Globalization;
namespace Course {
    class Produto {
        private string _nome;
        private double _preco;
        private int _quantidade;

        /* public Produto() {
          }  construtor de sobrecarga
        */
        /* Public Produto(){
           Quantidade = 10;
           }

         public Produto(string nome, double preco) : this() {
           Nome = nome; 
           Preco = preco;
          } 
         */

        /* Produto p = new Produto  ou Produto p = new Produto()  { 
          Nome = "TV",
          Preco = 900.0,
          Quantidade = 0 };
        */

        public Produto(string nome, double preco, int quantidade) { //construtor
            // construtor tem o mesmo nome da classe
             
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        

        /*public string GetNome(){
           return _nome
          }

         public void SetNome(string nome){
            _nome = nome;

        public void SetNome(string nome){
          if (nome != null && nome.Length > 1)
           _nome = nome;
       */

        /* public Produto(string nome, double preco) { construtor2
            Nome = nome;
            Preco = preco;
            Quantidade = 10;
        } */
    }
    public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
            // public double GetPreco() {
            // return _preco };
        }
        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
            // public int GetQuantidade() {
            // return _quantidade };
        }
        public override string ToString() {
        return _nome
        + ", $ "
        + _preco.ToString("F2", CultureInfo.InvariantCulture)
        + ", "
        + _quantidade
        + " unidades, Total: $ "
        + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
      }
    }
}