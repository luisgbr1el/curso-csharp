using System;
using System.IO;
using ExercicioAula192CSharp.Entities;
using System.Globalization;

namespace ExercicioAula192CSharp {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";

                Console.Write("Enter the file name you want to the output (ex: output.csv): ");
                string fileName = Console.ReadLine();

                string targetFilePath = targetFolderPath + $@"\{fileName}";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath)) {
                    foreach (string line in lines) {

                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                         }
                    Console.WriteLine();
                    Console.WriteLine($@"'{fileName}' created successfully in {targetFolderPath}\{fileName}");
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
