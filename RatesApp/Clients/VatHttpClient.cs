using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RatesApp.Dto;
using RatesApp.Interfaces;

namespace RatesApp.Clients
{
    public class VatHttpClient : IVatHttpClient
    {
        private readonly HttpClient _client = new HttpClient();

        public void Initialize()
        {
            _client.BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseUrl"]);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<VatRateDto> GetVatRates()
        {
            VatRateDto rootObject = null;
            HttpResponseMessage response = await _client.GetAsync("");
            if (response.IsSuccessStatusCode)
            {
                var rates = await response.Content.ReadAsStringAsync();
                rootObject = JsonConvert.DeserializeObject<VatRateDto>(rates);
            }
            return rootObject;
        }
    }
}