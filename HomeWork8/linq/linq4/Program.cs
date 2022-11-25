namespace linq4
{
    class Student
    {
        public string Name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var myStudents1 = new List<Student>()
            {
                new Student() { Name = "Alice" },
                new Student() { Name = "Bob" },
                new Student() { Name = "Claire"},
                new Student() { Name = "Alice"}
            };
            var myStudents2 = new List<Student>()
            {
                new Student() { Name = "Alice" },
                new Student() { Name = "Bob" },
                new Student() { Name = "Tim"},
                new Student() { Name = "Alice"}
            };
            var result = myStudents1.Intersect(myStudents2);
            Console.WriteLine("{0}", result.Count());
        }
    }
}