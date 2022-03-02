using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace EmailAPI.Models
{
    public class EmailContext : DbContext
    {
        public EmailContext(DbContextOptions<EmailContext> options) 
        : base(options)
        {
        }
        public DbSet<Email> Emails { get; set; } = null!;

    }
}