namespace Enum7
{
    internal enum Wage
    {
        Small,
        Medium,
        Large
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckWage((Wage)0));
            Console.WriteLine(CheckWage((Wage)2));
            Console.WriteLine(CheckWage((Wage)1));
            Console.ReadKey();
        }

        public static string CheckWage(Wage wage)
        {
            switch (wage)
            {
                case Wage.Small:
                    return "Small";
                case Wage.Medium:
                    return "Medium";
                case Wage.Large:
                    return "Large";
                default:
                    return "no wage";
            }
        }
    }
}