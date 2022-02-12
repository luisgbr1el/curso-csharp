using System;
using System.Globalization;

namespace ExercicioAula40CSharp {
    class Program {
        static void Main(string[] args) {

            // Exercício 1


            //Pessoa p1 = new Pessoa();
            //Pessoa p2 = new Pessoa();

            //Console.WriteLine("Dados da primeira pessoa:");
            //Console.Write("Nome: ");
            //p1.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //p1.Idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados da segunda pessoa:");
            //Console.Write("Nome: ");
            //p2.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //p2.Idade = int.Parse(Console.ReadLine());

            //if (p1.Idade > p2.Idade) {
            //    Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            //} else {
            //    Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            //}



            // Exercício 2

            //Funcionario f1 = new Funcionario();
            //Funcionario f2 = new Funcionario();

            //Console.WriteLine("Dados do primeiro funcionário:");
            //Console.Write("Nome: ");
            //f1.Nome = Console.ReadLine();
            //Console.Write("Salario: ");
            //f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Dados do segundo funcionário:");
            //Console.Write("Nome: ");
            //f2.Nome = Console.ReadLine();
            //Console.Write("Salario: ");
            //f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double media = (f1.Salario + f2.Salario) / 2;

            //Console.WriteLine($"Salário médio = {media.ToString("F2", CultureInfo.InvariantCulture)}");

            // Exercício 3

            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto.Estoque = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nDados do produto: {produto.Nome}, $ {produto.Preco.ToString("F2", CultureInfo.InvariantCulture)}, {produto.Estoque} unidades, Total: $ {(produto.ValorTotalEmEstoque()).ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
            int adcNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nDados do produto: {produto.Nome}, $ {produto.Preco.ToString("F2", CultureInfo.InvariantCulture)}, {produto.AdicionarProdutos(adcNumber)} unidades, Total: $ {(produto.AdicionarProdutos(adcNumber) * produto.Preco).ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("\nDigite o número de produtos a ser removido do estoque: ");
            int removeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nDados do produto: {produto.Nome}, $ {produto.Preco.ToString("F2", CultureInfo.InvariantCulture)}, {produto.RemoverProdutos(produto.AdicionarProdutos(adcNumber), removeNumber)} unidades, Total: $ {(produto.RemoverProdutos(produto.AdicionarProdutos(adcNumber), removeNumber) * produto.Preco).ToString("F2", CultureInfo.InvariantCulture)}");
        }

    }   

}
