using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioAula40CSharp {
    class Produto {

        public string Nome;
        public double Preco;
        public int Estoque;

        public double ValorTotalEmEstoque() {
            return Preco * Estoque;
        }

        public int AdicionarProdutos(int quantidadeAdd) {
 
            int newEstoqueAdd = Estoque + quantidadeAdd;

            return newEstoqueAdd;
        }

        public int RemoverProdutos(int estoque, int quantidadeRem) {

            int newEstoqueRemove = estoque - quantidadeRem;

            return newEstoqueRemove;
        }
    }
}
