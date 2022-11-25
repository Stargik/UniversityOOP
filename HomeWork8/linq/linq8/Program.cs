namespace linq8
{
    class Student
    {
        public string FirstName;
        public string LastName;
        public List<int> BookId;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var myStudents = new List<Student>()
            {
                new Student() { FirstName = "Bob", LastName = "Borisov", BookId = new List<int>() { 1, 24 } },
                new Student() { FirstName = "Adam", LastName = "Cepler", BookId = new List<int>() { 5, 6, 12, 15 } },
                new Student() { FirstName = "Clark", LastName = "Adler", BookId = new List<int>() { 7, 82, 34 } }
            };
            var studentlist = myStudents.Select(x => x.BookId.Count(y => y > 10)).ToList();
            foreach (var student in studentlist)
            {
                Console.WriteLine("{0}", student);
            }
        }
    }
}