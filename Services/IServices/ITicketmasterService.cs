using EncoreTIX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoreTIX.Services.IServices
{
    public interface ITicketmasterService
    {
        Task<List<Attraction>> SearchAttractionsAsync(string keyword = "Phish");
        Task<Attraction?> GetAttractionDetailsAsync(string id);
        Task<List<Event>> GetAttractionEventsAsync(string attractionId);
    }
}
