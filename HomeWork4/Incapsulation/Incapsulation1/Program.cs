namespace Incapsulation1
{
    class Modifiers
    {
        static void A()
        {
            Console.WriteLine("Modifiers A");
        }
        public static void B()
        {
            Console.WriteLine("Modifiers B");
            A();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Modifiers.B();
            Console.ReadKey();
        }
    }
}