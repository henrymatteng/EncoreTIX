using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoreTIX.Models
{
    public record TicketmasterEventsResponse
    (
        EmbeddedEvents _embedded
    );
    public record EmbeddedEvents(
        List<Event> Events
    );
}
