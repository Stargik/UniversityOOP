namespace VarDynamicObject14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic a = 2;
            a += 4;
            Console.WriteLine("a=" + a);
            Console.ReadKey(true);
        }
    }
}