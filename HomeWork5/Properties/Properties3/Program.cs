namespace Properties3
{
    class Student
    {
        public string name = "Іван";
        private int age = 18;

        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get { return age; }
        }
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