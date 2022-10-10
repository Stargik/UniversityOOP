namespace Incapsulation6
{
    class A
    {
        protected int a;
        void MethodA(A a1, B b1)
        {
            a1.a = 1;
            b1.a = 2;
        }
 
    }
    class B : A
    {
        void MethodB(A a1, B b1)
        {
            a1.a = 1;
            this.a = 10;
            b1.a = 2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}