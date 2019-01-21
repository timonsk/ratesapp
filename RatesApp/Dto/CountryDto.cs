using System.Collections.Generic;
using Newtonsoft.Json;

namespace RatesApp.Dto
{
    public class CountryDto
    {
        public string Name { get; set; }

        public string Code { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        public List<PeriodDto> Periods { get; set; }
    }
}