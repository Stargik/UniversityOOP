namespace linq7
{
    class Student
    {
        public string FirstName;
        public string LastName;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var myStudents = new List<Student>()
            {
                new Student() { FirstName = "Bob", LastName = "Borisov" },
                new Student() { FirstName = "Adam", LastName = "Cepler" },
                new Student() { FirstName = "Clark", LastName = "Adler" }
            };
            var studentlist = myStudents.OrderBy(x => x.FirstName).OrderBy(x => x.LastName).ToList();
            foreach (var student in studentlist)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}