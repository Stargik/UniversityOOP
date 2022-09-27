namespace TestPolymorphism5
{
    class TestOverload
    {
        public void DisplayOverload(int a, string a)
        {
            double a = 1.1;
            Console.WriteLine("DisplayOverload int a string a");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TestOverload to = new TestOverload();
            to.DisplayOverload(1, "a");
            Console.ReadKey();
        }
    }
}