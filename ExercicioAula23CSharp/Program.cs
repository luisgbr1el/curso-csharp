using System;
using System.Globalization;

namespace ExercicioAula23CSharp {
    class Program {
        static void Main(string[] args) {
            
            // Lendo informações para atribuir valores as variáveis
            Console.WriteLine("Entre com o seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos têm na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');

            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            
            // Mostrando no console todas as informações
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(vet[0]);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
