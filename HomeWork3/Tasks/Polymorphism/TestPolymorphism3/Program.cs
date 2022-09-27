namespace TestPolymorphism3
{
    class TestOverload
    {
        static public void DisplayOverload(int a)
        {
            Console.WriteLine("DisplayOverload static int");
        }
        public void DisplayOverload(int i)
        {
            Console.WriteLine("DisplayOverload void int");
        }
        public void DisplayOverload(string a)
        {
            Console.WriteLine("DisplayOverload void string");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TestOverload to = new TestOverload();
            TestOverload.DisplayOverload(1);
            to.DisplayOverload(1);
            to.DisplayOverload("aaa");
            Console.ReadKey();
        }
    }
}