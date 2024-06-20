using System.ComponentModel.DataAnnotations;

namespace EntriesService.Domain.DTOs;

public class EntryDTO
{
    [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero")]
    public decimal Amount { get; set; }
    public EntryType EntryType { get; set; }
}