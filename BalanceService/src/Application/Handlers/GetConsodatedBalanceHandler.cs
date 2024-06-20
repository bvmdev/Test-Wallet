using MediatR;
using BalanceService.Application.Commands;
using BalanceService.Domain.DTOs;
using BalanceService.Domain.Interfaces;

namespace BalanceService.Application.Services;

public class GetConsodatedBalanceHandler : IRequestHandler<GetConsolidatedBalanceCommand, ConsolidatedBalanceDTO>
{
    private readonly IEntryRepository _entryRepository;

    public GetConsodatedBalanceHandler(IEntryRepository entryRepository)
    {
        _entryRepository = entryRepository;
    }

    public async Task<ConsolidatedBalanceDTO> Handle(GetConsolidatedBalanceCommand command, CancellationToken cancellationToken)
    {
        var entries = await _entryRepository.GetEntriesAsync(command.CreatedAt);

        if (!entries.Any())
            return null;
        

        var totalDebit = entries.Where(x => x.Amount < 0).Sum(x => x.Amount);
        var totalCredit = entries.Where(x => x.Amount > 0).Sum(x => x.Amount);
        var balance = entries.Sum(x => x.Amount);
        var result = new ConsolidatedBalanceDTO(balance, totalDebit, totalCredit, command.CreatedAt);

        return result;
    }
}