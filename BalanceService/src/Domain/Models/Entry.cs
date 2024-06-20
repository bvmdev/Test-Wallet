using Microsoft.AspNetCore.Authentication;

namespace BalanceService.Domain;

public class Entry
{
    public int Id { get; set; }
    public decimal Amount { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public EntryType EntryType { get; private set; }
    
    public Entry(decimal Amount, DateTime createdAt, EntryType EntryType)
    {
        this.Amount = Amount;
        this.CreatedAt = DateTime.Now.ToUniversalTime();
        this.EntryType = EntryType;
    }
}