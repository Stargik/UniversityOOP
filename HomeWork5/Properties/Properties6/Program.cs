namespace Properties6
{
    class Student
    {
        private string name;
        public string name
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
            Student st = new Student();
            st.name = "Іван";
            Console.WriteLine("Ім'я студента: " + st.name);
            Console.ReadKey();
        }
    }
}