namespace VarDynamicObject4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object a = 5;
            Console.WriteLine("a=" + a);
            object b = "bbb";
            Console.WriteLine("b=" + b);
            object c = a;
            Console.WriteLine("c=" + c);
            object d = "aaa";
            Console.WriteLine("d=" + d);
            d = 10;
            Console.WriteLine("d=" + d);
        }
    }
}