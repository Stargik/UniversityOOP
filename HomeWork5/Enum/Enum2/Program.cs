namespace Enum2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wage wage = Wage.Small;
            ClothesSize size = ClothesSize.L;
            Console.WriteLine("Wage is {0}", wage);
            Console.WriteLine("Wage is {0}", (int)wage);
            Console.WriteLine("Size is {0}", size);
            Console.WriteLine("Size is {0}", (int)size);
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
    enum ClothesSize : Wage
    {
        XS,
        S,
        M,
        L,
        XL
    }
}