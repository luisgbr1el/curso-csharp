using System;

namespace ExercicioAula35CSharp {
    class Program {
        static void Main(string[] args) {


            // Exercício 1

            //Console.Write("Digite um número: ");
            //int x = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= x; i++) {
            //    int mod = i % 2;
            //    if (mod != 0) {
            //        Console.WriteLine(i + " - ÍMPAR");
            //    }




            // Exercício 2

            int N = int.Parse(Console.ReadLine());

            int iN = 0, ouT = 0;

            for (int i = 1; i <= N; i++) {

                    int x = int.Parse(Console.ReadLine());
                    if (x >= 10 && x <= 20) {
                        iN++;
                    }
                    else {
                        ouT++;
                    }
            }

            Console.WriteLine($"{iN} in");
            Console.WriteLine($"{ouT} out");

        }
    }
}
