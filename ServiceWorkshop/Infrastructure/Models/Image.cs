namespace ServiceWorkshop.Infrastructure.Models
{
    public class Image
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string? ImageLink { get; set; }

        public string? Group { get; set; }
    }
}
