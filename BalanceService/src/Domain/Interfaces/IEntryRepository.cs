using System.Runtime.InteropServices.JavaScript;

namespace BalanceService.Domain.Interfaces;

public interface IEntryRepository
{
    Task<List<Entry>> GetEntriesAsync(DateTime referenceDate);
}