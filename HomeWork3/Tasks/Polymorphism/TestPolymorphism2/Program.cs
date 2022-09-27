namespace TestPolymorphism1
{
    class TestOverload
    {
        public void DisplayOverload()
        {
            Console.WriteLine("DisplayOverload void");
        }
        public int DisplayOverload()
        {
            Console.WriteLine("DisplayOverload int");
            return 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TestOverload to = new TestOverload();
            to.DisplayOverload();
            int i = to.DisplayOverload();
            Console.ReadKey();
        }
    }
}