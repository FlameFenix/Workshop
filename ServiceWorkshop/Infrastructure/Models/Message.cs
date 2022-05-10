namespace ServiceWorkshop.Infrastructure.Models
{
    public class Message
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string? Title { get; set; }

        public string? Email { get; set; }

        public string? Text { get; set; }

        public string Date { get; set; } = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
    }
}
