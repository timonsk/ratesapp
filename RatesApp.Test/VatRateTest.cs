using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using RatesApp.Models;
using RatesApp.Test.Models;
using RatesApp.Test.TestCases;

namespace RatesApp.Test
{
    [TestFixture]
    public class VatRateTest
    {
        [TestCaseSource(typeof(VatRateTestCases), nameof(VatRateTestCases.VatRateLowestTestCases))]
        public void ShouldSortByLowest(DateTime effectiveDate, int amount, List<Country> countries, ExpectedResult expectedResult)
        {
            var vatRate = new VatRate();

            vatRate.Countries.AddRange(countries);

            var lowestRates = vatRate.GetLowest(effectiveDate, amount);

            Assert.AreEqual(expectedResult.RatesCount, lowestRates.Count);
            Assert.AreEqual(expectedResult.FirstContryCode, lowestRates.FirstOrDefault()?.Code);
        }

        [TestCaseSource(typeof(VatRateTestCases), nameof(VatRateTestCases.VatRateHighestTestCases))]
        public void ShouldSortByHighest(DateTime effectiveDate, int amount, List<Country> countries, ExpectedResult expectedResult)
        {
            var vatRate = new VatRate();

            vatRate.Countries.AddRange(countries);

            var lowestRates = vatRate.GetHighest(effectiveDate, amount);

            Assert.AreEqual(expectedResult.RatesCount, lowestRates.Count);
            Assert.AreEqual(expectedResult.FirstContryCode, lowestRates.FirstOrDefault()?.Code);
        }
    }
}
