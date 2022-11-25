namespace linq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 5, 14, 9 };
            var nums = from elem in list
                      where elem > 7
                      select elem;
            list[0] += 10;
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}