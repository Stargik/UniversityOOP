namespace linq9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "green", "brown", "blue", "red", "red" };
            string[] colors2 = { "green", "brown", "blue" };
            var query1 = colors.Concat(colors2);
            foreach (var q in query1)
            {
                Console.WriteLine(q);
            }
            string s = "g";
            var query = colors.Where(c => c.Contains(s));
            s = "n";
            query = query.Where(c => c.Contains(s));
            Console.WriteLine(query.Count());
        }
    }
}