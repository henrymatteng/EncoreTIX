using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoreTIX.Models
{
    public record Attraction(
        string Id,
        string Name,
        string? Description,
        string? Url,
        List<Image>? Images,
        ExternalLinks? ExternalLinks,
        UpcomingEvents? UpcomingEvents
    );
}
