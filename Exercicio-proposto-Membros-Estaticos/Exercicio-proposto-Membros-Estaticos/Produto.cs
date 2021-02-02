using System;
using System.Globalization;
using System.Text;

namespace Exercicio_proposto_Membros_Estaticos {
    class Produto {
        public string nome;
        public double preco;
        public int Quantidade;

        public double valorTotEmEstoque() {
            return preco * Quantidade;
        }
        public void adicionarProduto(int quantidade) {
            Quantidade += quantidade;
        }
        public void removerProduto(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return nome 
                + " , $ "
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                + " , "
                + Quantidade 
                + " unidades ,"
                + " Total: $ " 
                + valorTotEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
