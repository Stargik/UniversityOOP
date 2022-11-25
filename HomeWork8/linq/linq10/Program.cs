namespace linq10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "green", "brown", "blue", "red" };
            var query = colors.Where(c => c.Contains("g"));
            query = query.Where(c => c.Contains("n"));
            Console.WriteLine(query.Count());
        }
    }
}