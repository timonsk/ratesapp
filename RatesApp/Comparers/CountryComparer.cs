using System;
using System.Collections.Generic;
using System.Linq;
using RatesApp.Models;

namespace RatesApp.Comparers
{
    public class CountryComparer : IComparer<Country>
    {
        private readonly DateTime? _effectiveFrom;

        public CountryComparer()
        {
        }

        public CountryComparer(DateTime effectiveFrom)
        {
            _effectiveFrom = effectiveFrom;
        }
    
        public int Compare(Country country1, Country country2)
        {

            int value = 1;
            if (country1 != null && country2 == null)
            {
                value = 0;
            }
            else if (country1 == null && country2 != null)
            {
                value = 0;
            }
            else if (country1 != null)
            {
                if (_effectiveFrom != null)
                {
                    var country1Period = GetNearestEffectiveFromPeriod(country1);
                    var country2Period = GetNearestEffectiveFromPeriod(country2);

                    value = ComparePeriod(country1Period, country2Period);
                }
                else
                {
                    var isBigger = country1.Periods.Any(p=> country2.Periods.All(x=> ComparePeriod(p,x) > 0));
                    value = isBigger ? 1 : -1;
                }
            }
            return value;
        }

        private Period GetNearestEffectiveFromPeriod(Country country)
        {
            return country?.Periods
                .Where( p => p.EffectiveFrom <= _effectiveFrom)
                .OrderBy(p=> p.EffectiveFrom)
                .Last();
        }

        private int ComparePeriod(Period period1, Period period2)
        {
            int value = 1;
            if (period1 != null && period2 == null)
            {
                value = 0;
            }
            else if (period1 == null && period2 != null)
            {
                value = 0;
            }
            else if (period1 != null)
            {
                value = period1.Rates > period2.Rates ? 1 : -1;
            }

            return value;
        }
    }
}