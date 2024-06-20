namespace EntriesService.Domain.Interfaces;

public interface IEntryRepository
{
    Task<Entry> AddEntryAsync(Entry entry);
}