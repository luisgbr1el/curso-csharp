using System;
using System.Globalization;
using ExercicioAula133CSharp.Entities;
using System.Collections.Generic;

namespace ExercicioAula133CSharp {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                string choose = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (choose == "i" || choose == "I") {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(name, price, customsFee));
                } else if (choose == "u" || choose == "U") {
                    Console.Write("Manufacture date: ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, manufactureDate));
                } else if (choose == "c" || choose == "C") {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in list) {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
