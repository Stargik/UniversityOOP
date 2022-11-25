namespace linq5
{
    class Student
    {
        public int Age;
        public string Name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var myStudents = new List<Student>()
            {
                new Student() { Age = 18, Name = "Alice" },
                new Student() { Age = 20, Name = "Bob" },
                new Student() { Age = 18, Name = "Claire"},
                new Student() { Age = 18, Name = "Alice"}
            };
            Console.WriteLine(myStudents.Distinct().Count());
        }
    }
}