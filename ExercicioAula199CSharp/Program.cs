using System;
using System.Globalization;
using ExercicioAula199CSharp.Entities;
using ExercicioAula199CSharp.Services;

namespace ExercicioAula199CSharp {

    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, months);

            Console.WriteLine();
            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.Installments) {
                Console.WriteLine(installment);
            }
        }
    }
}
