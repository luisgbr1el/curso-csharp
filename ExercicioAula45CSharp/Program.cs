using System;
using System.Globalization;

namespace ExercicioAula45CSharp {
    class Program {
        static void Main(string[] args) {

            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            double largura = double.Parse(Console.ReadLine());
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("ÁREA = " + retangulo.Area(largura, altura).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + retangulo.Perimetro(largura, altura).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + retangulo.Diagonal(largura, altura).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
