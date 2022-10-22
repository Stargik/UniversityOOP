using System.Text.Json.Serialization;

namespace JSon
{
    internal class Book
    {
        //[JsonIgnore]
        public int PublishingHouseId { get; set; }
        //[JsonPropertyName("Name")]
        public string? Title { get; set; }
        public PublishingHouse? PublishingHouse { get; set; }
    }
}
