namespace VarDynamicObject5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic a = 5;
            Console.WriteLine("a=" + a);
            dynamic b = "bbb";
            Console.WriteLine("b=" + b);
            dynamic c = a;
            Console.WriteLine("c=" + c);
            dynamic d = "aaa";
            Console.WriteLine("d=" + d);
            d = 10;
            Console.WriteLine("d=" + d);
        }
    }
}