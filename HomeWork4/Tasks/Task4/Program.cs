namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeographyObject river = new River(2, 3, "River1", "Blue river", 20, 2000);
            GeographyObject mountain = new Mountain(4, 5, "Mountain2", "High mountain", 3000);
            Console.WriteLine("River:");
            river.GetInformation();
            Console.WriteLine("Mountain:");
            mountain.GetInformation();
        }
    }
}