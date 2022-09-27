namespace TestInheritance6
{
    class ClassA : ClassB, ClassC
    {
        public void Method1()
        {
            Console.WriteLine("Class A Method1");
        }
    }
    class ClassB
    {
        public string str = "aaa";
        public void Method2()
        {
            Console.WriteLine("Class B Method2");
        }
    }
    class ClassC
    {
        public void Method3()
        {
            Console.WriteLine("Class C Method3");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassB b = new ClassB();
            b.Method2();
            Console.ReadKey();
        }
    }
}