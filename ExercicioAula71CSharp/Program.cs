using System;

namespace ExercicioAula71CSharp {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Estudante[] vect = new Estudante[10];

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("\nAluguel #" + i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);

            }

            Console.WriteLine("\nQuartos ocupados: ");
            for (int i = 0; i < 10; i ++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

        }
    }
}
