using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoreTIX.Models
{
    public record Image (
        string Url,
        string? Ratio,
        int? Width,
        int? Height,
        bool? Fallback
    );
}
