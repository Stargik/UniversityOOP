namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGeographyObject river = new River(2, 3, "River1", "Blue river", 20, 2000);
            IGeographyObject mountain = new Mountain(4, 5, "Mountain2", "High mountain", 3000);
            Console.WriteLine("River:");
            river.GetInformation();
            Console.WriteLine("Mountain:");
            mountain.GetInformation();
        }
    }
}