namespace Properties2
{
    class Student
    {
        public string Name { get; set; } = "Іван";
        public int Age { get; set; } = 21;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Student st = new Student();
            st.Age = 18;
            Console.WriteLine("Ім'я студента: " + st.Name);
            Console.WriteLine("Вік студента: " + st.Age);
            Console.ReadKey();
        }
    }
}