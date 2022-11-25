namespace linq13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 40, 28, 35, 90, 60, 32, 68, 55 };
            var query = numbers.SkipWhile((x, y) => x > y * 10);
            foreach (var num in query)
            {
                Console.WriteLine("{0}", num);
            }
        }
    }
}