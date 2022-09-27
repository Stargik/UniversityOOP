using System.Text;

namespace TestException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                TestClass.Method1();
                
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Cath в Main: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Блок finally в Main");
            }
            Console.WriteLine("Конец метода Main");
        }
    }
    class TestClass 
    {
        public static void Method1()
        {
            try
            {
                Method2();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Catch in Method1: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Блок finally в Method1");
            }
            Console.WriteLine("Конец метода Method1");
        }

        static void Method2()
        {
            try
            {
                int x = 8;
                int y = x / 0;
            }
            finally
            {
                Console.WriteLine("Блок finally в Method2");
            }
            Console.WriteLine("Конец метода Method2");
        }
    }
}