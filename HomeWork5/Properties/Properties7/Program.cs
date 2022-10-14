namespace Properties7
{
    class Student
    {
        private static string name;
        public static string Name
        {
            set { name = value; }
            get { return name; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Student.Name = "Іван";
            Console.WriteLine("Ім'я студента: " + Student.Name);
            Console.ReadKey();
        }
    }
}