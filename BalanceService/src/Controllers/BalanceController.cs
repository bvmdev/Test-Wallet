using MediatR;
using Microsoft.AspNetCore.Mvc;
using BalanceService.Application.Commands;
using BalanceService.Domain;
using BalanceService.Domain.DTOs;

namespace BalanceService.Presentation;

[ApiController]
[Route("api/[controller]")]
public class BalanceController : ControllerBase
{
    private readonly IMediator _mediator;

    public BalanceController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost]
    public async Task<IActionResult> GetBalance([FromBody] GetBalanceDTO request)
    {
        var command = new GetConsolidatedBalanceCommand(request.ReferenceDate);
        var result = await _mediator.Send(command);
        if(result != null)
            return Ok(result);
        else
        {
            return NoContent();
        }
    }
}