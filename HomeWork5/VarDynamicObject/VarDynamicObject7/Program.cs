namespace VarDynamicObject7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic a;
            a = 10;
            Console.WriteLine("a= " + a);

            a = "aaa";
            Console.WriteLine("a= " + a);

            a = 3.1;
            Console.WriteLine("a= " + a);

            Console.WriteLine("a.SomeMethod = " + a.SomeMethod());
            Console.ReadKey(true);
        }
    }
}