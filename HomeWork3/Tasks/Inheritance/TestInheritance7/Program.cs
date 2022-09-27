namespace TestInheritance7
{
    class ClassA : ClassB
    {
        public void Method1()
        {
            Console.WriteLine("Class A Method1");
        }
    }
    class ClassB : ClassC
    {
        public string str = "aaa";
        public void Method2()
        {
            Console.WriteLine("Class B Method2");
        }
    }
    class ClassC : ClassA
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