namespace Abstract6
{
    public class A
    {
        public void Method1()
        {
            Console.WriteLine("class A Method1");
        }
    }
    public abstract class B : A
    {
        public new abstract void Method1();
    }
    public class C : B
    {
        public override void Method1()
        {
            Console.WriteLine("class C Method1");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new C();
            A c = new C();
            a.Method1();
            b.Method1();
            c.Method1();
            Console.ReadKey();
        }
    }
}