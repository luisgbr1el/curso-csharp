using System;
using ExercicioAula136CSharp.Entities;
using System.Collections.Generic;
using ExercicioAula136CSharp.Entities.Enums;
using System.Globalization;

namespace ExercicioAula136CSharp {
    class Program {
        static void Main(string[] args) {

            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Shape {i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                string rectangleOrCicle = Console.ReadLine();
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (rectangleOrCicle == "r") {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(width, height, color));
                }
                else if (rectangleOrCicle == "c") {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(radius, color));
                }


            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach(Shape obj in list) {
                Console.WriteLine(obj.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
