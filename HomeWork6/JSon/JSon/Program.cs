using System.Text.Json;

namespace JSon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string pathRead = @".\books.json";

            using (FileStream readStream = new FileStream(pathRead, FileMode.Open))
            {
                var books = JsonSerializer.Deserialize<List<Book>>(readStream);
                if (books != null)
                {
                    foreach (var book in books)
                    {
                        Console.WriteLine($"PublishingHouseId: {book.PublishingHouseId} | Title: {book.Title} | PublishingHouseName: {book.PublishingHouse?.Name} | PublishingHouseAdress: {book.PublishingHouse?.Adress}");
                    }
                }
            }
        }
    }
}