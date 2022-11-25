namespace linq6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new List<string>() { "bac", "dbce", "acbfg", "bcad", "acbd" };
            var words1 = words.Where(x => x.Contains("cb"));
            Console.WriteLine(words1.Count());
        }
    }
}