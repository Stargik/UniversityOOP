namespace TestPolymorphism4
{
    class TestOverload
    {
        public void DisplayOverload()
        {
            Console.WriteLine("DisplayOverload public");
        }
        protected void DisplayOverload()
        {
            Console.WriteLine("DisplayOverload protected");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TestOverload to = new TestOverload();
            to.DisplayOverload();
            Console.ReadKey();
        }
    }
}