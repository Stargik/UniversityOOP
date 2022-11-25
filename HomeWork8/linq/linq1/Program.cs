namespace linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<string>() { "4", "2", "5", "12", "1"};
            foreach (var number in numbers.OrderBy(x => x))
            {
                Console.WriteLine("{0}", number);
            }
        }
    }
}