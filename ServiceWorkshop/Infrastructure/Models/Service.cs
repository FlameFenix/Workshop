using System.ComponentModel.DataAnnotations;

namespace ServiceWorkshop.Infrastructure.Models
{
    public class Service
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string? Name { get; set; }

        public string? Description { get; set; }
    }
}
