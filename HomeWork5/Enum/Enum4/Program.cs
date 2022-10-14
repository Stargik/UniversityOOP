namespace Enum4
{
    enum Wage
    {
        Small,
        Medium,
        Pretty_med,
        Large
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int wage = 1;
            Console.WriteLine(Wage.Medium.CompareTo(Wage.Small));
            Console.WriteLine(Wage.Medium.CompareTo(Wage.Medium));
            Console.WriteLine(Wage.Medium.CompareTo(Wage.Large));

            if (wage == Wage.Medium)
            {
                Console.WriteLine("true");
            }

            if (wage == (int)Wage.Medium)
            {
                Console.WriteLine("true");
            }

            Console.ReadKey();
        }
    }
}