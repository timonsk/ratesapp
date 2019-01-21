using System;
using System.Collections.Generic;
using RatesApp.Models;

namespace RatesApp.Test.TestData
{
    public static class VatRateTestData
    {  
        public static List<Country> GetCountriesWithEffectiveFromPeriods()
        {
            var result = new List<Country>
            {
                new Country
                {
                    Code = "ru",
                    Periods = new List<Period>
                    {
                        new Period
                        {
                            EffectiveFrom = new DateTime(2000,11,1),
                            Rates = new Rate {Standard = 4}
                        },
                        new Period
                        {
                            EffectiveFrom = new DateTime(2002,11,1),
                            Rates = new Rate {Standard = 0.5}
                        },
                    }
                },
                new Country
                {
                    Code = "ua",
                    Periods = new List<Period>
                    {
                        new Period
                        {
                            EffectiveFrom = new DateTime(2001,11,1),
                            Rates = new Rate {Standard = 3}
                        }
                    }
                },
                new Country
                {
                    Code = "en",
                    Periods = new List<Period>
                    {
                        new Period
                        {
                            Rates = new Rate {Standard = 1}
                        }
                    }
                },
                new Country
                {
                    Code = "us",
                    Periods = new List<Period>
                    {
                        new Period
                        {
                            Rates = new Rate {Standard = 2}
                        }
                    }
                },
                new Country
                {
                    Code = "pl",
                    Periods = new List<Period>
                    {
                        new Period
                        {
                            Rates = new Rate {Standard = 3}
                        }
                    }
                }
            };




            return result;
        }
        public static List<Country> GetCountries()
        {
            var result = new List<Country>
            {
                new Country
                {
                    Code = "ru",
                    Periods = new List<Period>
                    {
                        new Period
                        {
                            Rates = new Rate {Standard = 4}
                        },

                    }
                },
                new Country
                {
                    Code = "ua",
                    Periods = new List<Period>
                    {
                        new Period
                        {
                            Rates = new Rate {Standard = 3}
                        }
                    }
                },
                new Country
                {
                    Code = "en",
                    Periods = new List<Period>
                    {
                        new Period
                        {
                            Rates = new Rate {Standard = 1}
                        }
                    }
                },
                new Country
                {
                    Code = "us",
                    Periods = new List<Period>
                    {
                        new Period
                        {
                            Rates = new Rate {Standard = 2}
                        }
                    }
                },
                new Country
                {
                    Code = "pl",
                    Periods = new List<Period>
                    {
                        new Period
                        {
                            Rates = new Rate {Standard = 3}
                        }
                    }
                }
            };




            return result;
        }
    }
}