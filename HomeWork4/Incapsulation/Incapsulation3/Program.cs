namespace Incapsulation3
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
        }
        protected static void C()
        {
            Console.WriteLine("Modifiers C");
        }
    }
    class ModifiersChild : Modifiers
    {
        public static void D()
        {
            A();
            B();
            C();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ModifiersChild.D();
            Console.ReadKey();
        }
    }
}