using System;
using System.Globalization;

namespace ExercicioAula29CSharp {
    class Program {
        static void Main(string[] args) {

            string[] vet = Console.ReadLine().Split(' ');

            int code = int.Parse(vet[0]);
            double quantity = double.Parse(vet[1]);

            if (code == 1) {
                Console.WriteLine("R$ " + (quantity * 4.00).ToString("F2", CultureInfo.InvariantCulture));
            } else if (code == 2) {
                Console.WriteLine("R$ " + (quantity * 4.50).ToString("F2", CultureInfo.InvariantCulture));
            } else if (code == 3) {
                Console.WriteLine("R$ " + (quantity * 5.00).ToString("F2", CultureInfo.InvariantCulture));
            } else if (code == 4) {
                Console.WriteLine("R$ " + (quantity * 2.00).ToString("F2", CultureInfo.InvariantCulture));
            } else if (code == 5) {
                Console.WriteLine("R$ " + (quantity * 1.50).ToString("F2", CultureInfo.InvariantCulture));
            } else {
                Console.WriteLine("Código inválido! Esse item não existe.");
            }
        }
    }
}
