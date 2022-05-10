namespace ServiceWorkshop.Infrastructure.Models
{
    public class Article
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string? ImageLink { get; set; }

        public string? Title { get; set; }

        public string? Date { get; set; }

        public string? Description { get; set; }
    }
}
