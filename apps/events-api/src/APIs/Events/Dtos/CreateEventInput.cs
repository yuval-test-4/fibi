using System.ComponentModel.DataAnnotations;

namespace EventsApi.APIs;

public class CreateEventInput
{
    [Required()]
    public string Message { get; set; }

    [Required()]
    public string Group { get; set; }
}
