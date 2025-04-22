using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoreTIX.Models
{
    public record ExternalLinks(
        List<ExternalLink>? Twitter,
    List<ExternalLink>? Facebook,
    List<ExternalLink>? Instagram,
    List<ExternalLink>? YouTube,
    List<ExternalLink>? Spotify,
    List<ExternalLink>? Homepage
        );

    public record ExternalLink(string Url);
}
