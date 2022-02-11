using System;
using System.Globalization;

namespace ExercicioAula18CSharp {
    class Program {
        static void Main(string[] args) {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}\n");

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}\n");

            Console.WriteLine($"Medidas com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture) + "\n");

            double n1 = 6.0;
            double n2 = 5.0;
            double divisao = n1 / n2;

            Console.WriteLine(divisao.ToString("F2"));
            if (n1 % n2 == 0) {
                Console.WriteLine("A divisão é exata!");
            } else {
                Console.WriteLine("A divisão NÃO é exata!");
            }

        }
    }
}
