namespace Abstract7
{
    public class A
    {
        public void Method1()
        {
            Console.WriteLine("class A Method1");
        }
    }
    public static abstract class B : A
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
            A b = new A();
            A c = new A();
            a.Method1();
            b.Method1();
            c.Method1();
            Console.ReadKey();
        }
    }
}