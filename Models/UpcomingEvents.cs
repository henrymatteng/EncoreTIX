using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoreTIX.Models
{
    public record UpcomingEvents(
        int? Total,
        int? Ticketmaster,
        int? Tmr,
        int? Universe,
        int? Frontgate
    );
}
