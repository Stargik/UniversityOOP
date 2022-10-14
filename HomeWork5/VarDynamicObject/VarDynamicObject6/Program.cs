namespace VarDynamicObject6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            Console.WriteLine("a=" + a);
            var b = "bbb";
            Console.WriteLine("b=" + b);
            var c = a;
            Console.WriteLine("c=" + c);
            var d = "aaa";
            Console.WriteLine("d=" + d);
            d = 10;
            Console.WriteLine("d=" + d);
        }
    }
}