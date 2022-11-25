namespace linq11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "green", "purple", "red", "yellow" };
            var query = from c in colors
                        where c.Length == colors.Average(x => x.Length)
                        select c;
            foreach (var color in query)
            {
                Console.WriteLine("{0}", color);
            }
        }
    }
}