using System.Collections.Generic;

namespace RatesApp.Dto
{
    public class VatRateDto
    {
        public List<CountryDto> Rates { get; set; } = new List<CountryDto>();
    }
}