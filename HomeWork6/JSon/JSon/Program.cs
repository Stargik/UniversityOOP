using System.Text.Json;
using System.Threading.Tasks;

namespace JSon
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string pathRead = @".\books.json";

            using (FileStream readStream = new FileStream(pathRead, FileMode.Open))
            {
                var books = await JsonSerializer.DeserializeAsync<List<Book>>(readStream);
                if (books is not null)
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