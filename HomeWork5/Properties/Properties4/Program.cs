namespace Properties4
{
    class Student
    {
        public string name = "Іван";
        private int age = 18;

        public string Name
        {
            set { name = value; }
        }
        public int Age
        {
            set { age = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Student st = new Student();
            st.Age = 18;
            st.Name = "Іван";
            Console.WriteLine("Ім'я студента: " + st.Name);
            Console.WriteLine("Вік студента: " + st.Age);
            Console.ReadKey();
        }
    }
}