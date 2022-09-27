namespace TestPolymorphism2
{
    class TestOverload
    {
        public void DisplayOverload(int a)
        {
            Console.WriteLine("DisplayOverload " + a);
        }
        public void DisplayOverload(string a)
        {
            Console.WriteLine("DisplayOverload " + a);
        }
        public void DisplayOverload(string a, int b)
        {
            Console.WriteLine("DisplayOverload " + a + b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TestOverload to = new TestOverload();
            to.DisplayOverload(100);
            to.DisplayOverload("aaa");
            to.DisplayOverload("bbb", 2);
            Console.ReadKey();
        }
    }
}