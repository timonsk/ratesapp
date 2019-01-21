using Newtonsoft.Json;
using System;

namespace RatesApp.Dto
{
    public class PeriodDto
    {
        [JsonProperty("effective_from")]
        public string EffectiveFrom { get; set; }

        public RateDto Rates { get; set; }
    }
}