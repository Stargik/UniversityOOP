using TestModifierLibrary4;
namespace Incapsulation4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            a.MethodA();
            b.MethodB();
            Console.ReadKey();
        }
    }
}