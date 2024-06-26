using MediatR;
using Microsoft.AspNetCore.Mvc;
using EntriesService.Application.Commands;
using EntriesService.Domain;

namespace EntriesService.Presentation;

[ApiController]
[Route("api/[controller]")]
public class EntryTypeController : ControllerBase
{
    
    [HttpGet]
    public async Task<IActionResult> GetEntryTypesAsync()
    {
        var values = Enum.GetValues(typeof(EntryType))
            .Cast<EntryType>()
            .Select(e => new { Id = (int)e, Name = e.ToString() })
            .ToList();

        return Ok(values);
    }
}