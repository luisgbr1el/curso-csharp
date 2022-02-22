using System;
using ExercicioAula137CSharp.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioAula137CSharp {
    class Program {
        static void Main(string[] args) {

            List<Tax> list = new List<Tax>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Tax payer {i} data:");
                Console.Write("Individual or company (i/c)? ");
                string choose = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (choose == "i") {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new IndividualPayer(name, anualIncome, healthExpenditures));
                }
                else if (choose == "c") {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());

                    list.Add(new CompanyPayer(name, anualIncome, numberEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double totalTaxes = 0.0;
            foreach(Tax obj in list) {
                Console.WriteLine($"{obj.Name}: $ {obj.TaxesPaid().ToString("F2", CultureInfo.InvariantCulture)}");
                totalTaxes += obj.TaxesPaid();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
