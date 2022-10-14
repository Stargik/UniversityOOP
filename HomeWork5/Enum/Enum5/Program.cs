namespace Enum5
{
    enum Wage
    {
        Small = 90,
        Medium,
        Pretty_med = 100,
        Large
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names;
            names = Wage.GetNames(typeof(Wage));

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine((int)Wage.Medium);
            Console.WriteLine((int)Wage.Large);
            Console.ReadLine();
        }
    }
}