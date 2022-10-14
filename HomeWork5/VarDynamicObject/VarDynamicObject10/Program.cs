namespace VarDynamicObject10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new { Name = "Ivan", Age = 17 };
            Console.WriteLine("a.Name=" + a.Name);
            Console.ReadKey(true);
        }
    }
}