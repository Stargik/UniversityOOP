namespace Abstract5
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
        public override void Method2()
        {
            base.Method2();
            Console.WriteLine("abstract Class B Method2");
        }
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