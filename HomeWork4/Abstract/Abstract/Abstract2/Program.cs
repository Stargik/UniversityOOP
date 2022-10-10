namespace Abstract2
{
    public abstract class A
    {
        public int a;
        public void Method1()
        {
            Console.WriteLine("abstract Class A Method1");
        }
        abstract public void Method2();
    }
    public class B : A
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.Method1();
            Console.ReadKey();
        }
    }
}