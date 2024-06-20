using MediatR;
using BalanceService.Domain;
using BalanceService.Domain.DTOs;

namespace BalanceService.Application.Commands;   

public class GetConsolidatedBalanceCommand : IRequest<ConsolidatedBalanceDTO>
{
        public DateTime CreatedAt { get; private set; }

        public GetConsolidatedBalanceCommand(DateTime createdAt)
        {
            
            CreatedAt = createdAt.ToUniversalTime();
            
        }
    
}