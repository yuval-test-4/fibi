using EventsApi.APIs;
using EventsApi.APIs.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EventsApi.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class EventsControllerBase : ControllerBase
{
    protected readonly IEventsService _service;

    public EventsControllerBase(IEventsService service)
    {
        _service = service;
    }

    [HttpPost("")]
    [Authorize(Roles = "user")]
    public async Task<string> CreateEvent([FromBody()] CreateEventInput createEventInputDto)
    {
        return await _service.CreateEvent(createEventInputDto);
    }
}
