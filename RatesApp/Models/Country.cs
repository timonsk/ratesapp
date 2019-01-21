using System.Collections.Generic;

namespace RatesApp.Models
{
    public class Country 
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public string CountryCode { get; set; }

        public List<Period> Periods { get; set; } = new List<Period>();
    }
}