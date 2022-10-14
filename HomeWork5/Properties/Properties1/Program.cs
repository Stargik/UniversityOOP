namespace Properties1
{
    class Square
    {
        private double side;
        public double Area
        {
            get { return side * side; }
            set { side = Math.Sqrt(value); }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Square t = new Square();

            t.Area = 25;

            Console.WriteLine("Площа квадрата: " + t.Area);
            Console.ReadKey();
        }
    }
}