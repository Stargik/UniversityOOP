namespace Properties5
{
    class Student
    {
        private string name;

        public string Name
        {
            set { name = value; }
        }
        public string Name
        {
            get { return name; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Student st = new Student();
            st.Name = "Іван";
            Console.WriteLine("Ім'я студента: " + st.Name);
            Console.ReadKey();
        }
    }
}