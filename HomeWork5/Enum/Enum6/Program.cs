namespace Enum6
{
    enum Wage
    {
        Small = 90,
        Medium,
        Pretty_med = Small,
        Large
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Wage.Medium);
            Console.WriteLine((int)Wage.Large);
            Console.ReadLine();
        }
    }
}