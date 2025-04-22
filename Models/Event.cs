using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoreTIX.Models
{
    public record Event
    (
        string Id,
        string Name,
        string? Url,
        List<Image>? Images,
        EventDates? Dates,
        EmbeddedVenues? _embedded
    );

    public record EventDates(
        EventStart? Start,
        EventStatus? Status
    );

    public record EventStart(
        string? LocalDate,
        string? LocalTime,
        string? DateTime
    );

    public record EventStatus(
        string? Code
    );

    public record EmbeddedVenues(
        List<Venue>? Venues
    );
}
