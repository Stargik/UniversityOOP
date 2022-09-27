namespace TestInheritance5
{
    class ClassA : ClassB
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
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassB b = new ClassB();
            b.Method1();
            Console.ReadKey();
        }
    }
}