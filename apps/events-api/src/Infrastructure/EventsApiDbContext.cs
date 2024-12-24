using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EventsApi.Infrastructure;

public class EventsApiDbContext : IdentityDbContext<IdentityUser>
{
    public EventsApiDbContext(DbContextOptions<EventsApiDbContext> options)
        : base(options) { }
}
