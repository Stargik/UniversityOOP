using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            string? mes = Console.ReadLine();
            int number;
            if (int.TryParse(mes, out number))
            {
                Console.WriteLine($"Ви ввели число {number}");
            }
            else
            {
                Console.WriteLine("Ви ввели не число");
            }
        }
    }
}