using EncoreTIX.Models;
using EncoreTIX.Services.IServices;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace EncoreTIX.Services
{
    public class TicketmasterService : ITicketmasterService
    {
        private readonly HttpClient _httpClient;
        private readonly TicketmasterSettings _settings;

        public TicketmasterService(HttpClient httpClient, IOptions<TicketmasterSettings> options)
        {
            _httpClient = httpClient;
            _settings = options.Value;
        }

        public async Task<List<Attraction>> SearchAttractionsAsync(string keyword = "Phish")
        {
            var url = $"{_settings.BaseUrl}/attractions.json?apikey={_settings.ApiKey}&keyword={Uri.EscapeDataString(keyword)}";

            var response = await _httpClient.GetFromJsonAsync<TicketmasterAttractionsResponse>(url);

            return response?._embedded?.attractions ?? new List<Attraction>();
        }

        public async Task<Attraction?> GetAttractionDetailsAsync(string id)
        {
            var url = $"{_settings.BaseUrl}/attractions/{id}.json?apikey={_settings.ApiKey}";

            return await _httpClient.GetFromJsonAsync<Attraction>(url);
        }

        public async Task<List<Event>> GetAttractionEventsAsync(string attractionId)
        {
            var url = $"{_settings.BaseUrl}/events.json?apikey={_settings.ApiKey}&attractionId={Uri.EscapeDataString(attractionId)}";

            var response = await _httpClient.GetFromJsonAsync<TicketmasterEventsResponse>(url);

            return response?._embedded?.Events ?? new List<Event>();
        }
    }
}
