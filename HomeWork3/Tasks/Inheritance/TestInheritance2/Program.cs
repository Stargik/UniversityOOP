namespace TestInheritance2
{
    class ClassA : ClassB
    {

    }
    class ClassB
    {
        public string str = "aaa";
        public void Method1()
        {
            Console.WriteLine("Class B Method1");
        }
        public void Method2()
        {
            Console.WriteLine("Class B Method2");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            a.Method1();
            Console.ReadKey();
        }
    }
}