using System;
using System.Collections.Generic;

namespace RatesApp.Models
{
    public class Period 
    {
        public DateTime EffectiveFrom { get; set; }

        public Rate Rates { get; set; }
    }
}