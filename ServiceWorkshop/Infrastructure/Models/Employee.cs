using System.ComponentModel.DataAnnotations;

namespace ServiceWorkshop.Infrastructure.Models
{
    public class Employee
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string? Name { get; set; }

        public string? Position { get; set; }

        public string? FaceBookLink { get; set; }

        public string? TwitterLink { get; set; }

        public string? GoogleLink { get; set; }

    }
}
