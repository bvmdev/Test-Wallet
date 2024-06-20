using Microsoft.EntityFrameworkCore;
using BalanceService.Domain;

namespace BalanceService.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public DbSet<Entry> Entries { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}