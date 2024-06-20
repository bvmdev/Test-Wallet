using Microsoft.EntityFrameworkCore;
using EntriesService.Domain;

namespace EntriesService.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public DbSet<Entry> Entries { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}