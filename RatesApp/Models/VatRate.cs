using System;
using System.Collections.Generic;
using System.Linq;
using RatesApp.Comparers;

namespace RatesApp.Models
{
    public class VatRate
    {
        private bool _needSorting = true;
        private List<Country> _countries = new List<Country>();

        public List<Country> Countries
        {
            get => _countries;
            set
            {
                if (value != _countries)
                {
                    _needSorting = true;
                }

                _countries = value;
            }
        }

        public List<Country> GetHighest(DateTime effectiveFrom, int amount = 1)
        {
            Sort(effectiveFrom);
            return Countries
                .TakeLast(amount)
                .Reverse()
                .ToList();
        }

        public List<Country> GetLowest(DateTime effectiveFrom, int amount = 1)
        {
            Sort(effectiveFrom);
            return Countries
                .Take(amount)
                .ToList();
        }

        private void Sort(DateTime effectiveFrom)
        {
            if (_needSorting)
            {
                Countries.Sort(new CountryComparer(effectiveFrom));
                _needSorting = false;
            }
        }
    }
}