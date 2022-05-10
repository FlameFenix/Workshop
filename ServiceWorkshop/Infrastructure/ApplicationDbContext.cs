using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServiceWorkshop.Infrastructure.Models;

namespace ServiceWorkshop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Article>? Articles { get; set; }

        public DbSet<Employee>? Employees { get; set; }

        public DbSet<Image>? Images { get; set; }

        public DbSet<Message>? Messages { get; set; }

        public DbSet<Service>? Services { get; set; }
    }
}