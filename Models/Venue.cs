using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoreTIX.Models
{
    public record Venue(
        string Id,
        string Name,
        string? Url,
        Address? Address,
        City? City,
        Country? Country
        );

    public record Address(string? Line1);
    public record City(string? Name);
    public record Country(string? Name, string? CountryCode);
}
