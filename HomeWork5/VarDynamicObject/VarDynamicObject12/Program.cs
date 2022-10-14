namespace VarDynamicObject12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object a = new { Name = "Ivan", Age = 17 };
            Console.WriteLine("a.Name=" + a.Name);
            Console.ReadKey(true);
        }
    }
}