using System;
using System.Globalization;
using ExercicioAula146CSharp.Entities;
using ExercicioAula146CSharp.Entities.Exceptions;

namespace ExercicioAula146CSharp {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, balance, withdrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try {
                account.Withdraw(amount);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (WithdrawLimit e) {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e) {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (Exception e) {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
