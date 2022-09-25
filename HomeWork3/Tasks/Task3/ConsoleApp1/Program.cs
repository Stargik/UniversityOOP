using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter;
            decimal usdCurrency, eurCurrency;
            while (true)
            {
                Console.WriteLine("Enter usd currency: ");
                string? usd = Console.ReadLine();
                Console.WriteLine("Enter eur currency: ");
                string? eur = Console.ReadLine();
                if (Decimal.TryParse(usd, out usdCurrency) && Decimal.TryParse(eur, out eurCurrency))
                {
                    if (usdCurrency != 0 && eurCurrency != 0)
                    {
                        converter = new Converter(usdCurrency, eurCurrency);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            }
            while (true)
            {
                decimal value;
                Console.WriteLine("Enter value(f - for finish): ");
                string? input = Console.ReadLine();
                if (input == "f")
                {
                    break;
                }
                Console.WriteLine("Enter current currency (USD/EUR/UAH): ");
                string? current = Console.ReadLine();
                Console.WriteLine("Enter convert currency (USD/EUR for current UAH or UAH for current USD/EUR): ");
                string? convert = Console.ReadLine();
                if (Decimal.TryParse(input, out value) && !String.IsNullOrEmpty(current) && !String.IsNullOrEmpty(convert))
                {
                    try
                    {
                        decimal res = converter.Convert(value, current, convert);
                        Console.WriteLine($"Result: {res}");
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Incorrect input");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            }


        }
    }
}