namespace BalanceService.Domain.DTOs;

public class ConsolidatedBalanceDTO
{
    public Decimal Balance { get; private set; }
    
    public Decimal TotalDebit {
        get;
        private set;
    }
    
    public Decimal TotalCredit {
        get;
        private set;
    }

    public DateTime ReferenceDate { get; set; }
    
    public ConsolidatedBalanceDTO(Decimal balance, Decimal totalDebit, Decimal totalCredit, DateTime referenceDate)
    {
        this.Balance = balance;
        this.TotalDebit = totalDebit;
        this.TotalCredit = totalCredit;
        this.ReferenceDate = referenceDate;
    }
    
    
}