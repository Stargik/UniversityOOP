namespace Enum1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wage wage = Wage.Small;
            Console.WriteLine("Wage is {0}", wage);
            Console.WriteLine("Wage is {0}", (int)wage);
            Console.ReadKey();
        }
    }

    enum Wage
    {
        Small,
        Medium,
        Pretty_med,
        Large
    }
}