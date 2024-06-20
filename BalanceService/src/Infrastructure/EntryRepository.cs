using BalanceService.Domain;
using BalanceService.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BalanceService.Infrastructure;

public class EntryRepository : IEntryRepository
{
    private readonly ApplicationDbContext _context;
    
    public EntryRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Entry>> GetEntriesAsync(DateTime referenceDate)
    {
        return await _context.Entries.Where(x=> x.CreatedAt.Date == referenceDate.Date).ToListAsync();
    }
}