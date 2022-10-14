class Student
{
    public int age;
    public string name;
    public Student(int a, string n)
    {
        age = a;
        name = n;
    }
}
internal class Program
{
    static void Main()
    {
        Student st1 = new Student();
        Student st2 = new Student(16, "Ivan");
        Student st3;
        st3.name = "Kolya";

        Console.WriteLine("st1: name {0}, age {1}", st1.name, st1.age);
        Console.WriteLine("st2: name {0}, age {1}", st2.name, st2.age);
        Console.WriteLine("st3: name {0}, age {1}", st3.name, st3.age);
        Console.ReadKey(true);
    }
}