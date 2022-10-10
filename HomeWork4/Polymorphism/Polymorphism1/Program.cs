namespace Polymorphism1
{
    public class Class1
    {
        public void Method1()
        {
            Console.WriteLine("Class1 Method1");
        }
        public void Method2()
        {
            Console.WriteLine("Class1 Method2");
        }
    }

    public class Class2 : Class1
    {
        public void Method1()
        {
            Console.WriteLine("Class2 Method1");
        }
        public void Method2()
        {
            Console.WriteLine("Class2 Method2");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 x = new Class1();
            Class2 y = new Class2();
            Class1 z = new Class2();

            x.Method1();
            x.Method2();
            Console.WriteLine("");
            y.Method1();
            y.Method2();
            Console.WriteLine("");
            z.Method1();
            z.Method2();
            Console.ReadKey();
        }
    }
}