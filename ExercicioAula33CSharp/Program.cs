using System;
using System.Globalization;

namespace ExercicioAula33CSharp {
    class Program {
        static void Main(string[] args) {

            // Exercício 1
            //Console.WriteLine("Digite a senha:");
            //int pass = int.Parse(Console.ReadLine());

            //while (pass != 2002) {
            //    Console.WriteLine("\nSenha inválida!");
            //    Console.WriteLine("Digite a senha:");
            //    pass = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\nAcesso permitido.");




            // Exercício 2

            //string[] vet = Console.ReadLine().Split(' ');

            //int x = int.Parse(vet[0]);
            //int y = int.Parse(vet[1]);

            ////Console.WriteLine("X = " + x + "\nY = " + y);
            //while (x != 0 && y != 0) {

            //    if (x > 0 && y > 0) {
            //        Console.WriteLine("primeiro");
            //    }

            //    else if (x < 0 && y > 0) {
            //        Console.WriteLine("segundo");
            //    }

            //    else if (x < 0 && y < 0) {
            //        Console.WriteLine("terceiro");
            //    }

            //    else if (x > 0 && y < 0) {
            //        Console.WriteLine("quarto");
            //    }

            //    vet = Console.ReadLine().Split(' ');

            //    x = int.Parse(vet[0]);
            //    y = int.Parse(vet[1]);

            //}



            // Exercício 3

            int produto = int.Parse(Console.ReadLine());

            int alcool = 0, gasolina = 0, diesel = 0;

            while (produto != 4) {
                
                if (produto == 1) {
                    alcool++;
                    produto = int.Parse(Console.ReadLine());
                } else if (produto == 2) {
                    gasolina++;
                    produto = int.Parse(Console.ReadLine());
                } else if (produto == 3) {
                    diesel++;
                    produto = int.Parse(Console.ReadLine());
                } else {
                    produto = int.Parse(Console.ReadLine());
                }

            }

            Console.WriteLine("\n---------------");
            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
            Console.WriteLine("---------------");



        }
    }
}
