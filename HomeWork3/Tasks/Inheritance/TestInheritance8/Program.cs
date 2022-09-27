namespace TestInheritance8
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
            ClassB classB = new ClassB();
            ClassA classA = new ClassA();
            classB = classA;
            classA = classB;
            classA.Method1();
            Console.ReadKey();
        }
    }
}