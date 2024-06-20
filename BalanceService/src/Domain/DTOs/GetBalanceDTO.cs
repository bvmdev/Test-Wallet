using System.ComponentModel.DataAnnotations;

namespace BalanceService.Domain.DTOs;

public class GetBalanceDTO
{
    public DateTime ReferenceDate {
        get;
        set;
    }
}