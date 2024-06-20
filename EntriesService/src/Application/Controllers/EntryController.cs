using MediatR;
using Microsoft.AspNetCore.Mvc;
using EntriesService.Application.Commands;
using EntriesService.Domain;
using EntriesService.Domain.DTOs;

namespace EntriesService.Presentation;

[ApiController]
[Route("api/[controller]")]
public class EntryController : ControllerBase
{
    private readonly IMediator _mediator;

    public EntryController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost]
    public async Task<IActionResult> AddEntryAsync([FromBody] EntryDTO entry)
    {
        var command = new AddEntryCommand(entry.Amount, entry.EntryType);
        await _mediator.Send(command);
        return Ok();
    }
}