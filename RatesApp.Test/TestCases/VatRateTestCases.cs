using System;
using System.Collections;
using NUnit.Framework;
using RatesApp.Test.TestData;
using RatesApp.Test.Models;

namespace RatesApp.Test.TestCases
{
    public class VatRateTestCases
    {
        public static IEnumerable VatRateLowestTestCases()
        {
            yield return new TestCaseData(DateTime.Now, 3,
                    VatRateTestData.GetCountries(), new ExpectedResult(3, "en"))
                .SetName("ShouldSortBy3CountiresLowest_Success");

            yield return new TestCaseData(DateTime.Now, 2,
                    VatRateTestData.GetCountries(), new ExpectedResult(2, "en"))
                .SetName("ShouldSortBy2CountiresLowest_Success");

            yield return new TestCaseData(DateTime.Now, null,
                    VatRateTestData.GetCountries(), new ExpectedResult(0, null))
                .SetName("ShouldSortByNullCountiresLowest_Success");

            yield return new TestCaseData(DateTime.Now, 0,
                    VatRateTestData.GetCountries(), new ExpectedResult(0, null))
                .SetName("ShouldSortBy0CountiresLowest_Success");

            yield return new TestCaseData(DateTime.Now, 3, 
                    VatRateTestData.GetCountriesWithEffectiveFromPeriods(), new ExpectedResult(3, "ru"))
                .SetName("ShouldSortBy3CountiresWithMultiplePeriodsLowest_Success");
        }

        public static IEnumerable VatRateHighestTestCases()
        {
            yield return new TestCaseData(DateTime.Now, 0, 
                    VatRateTestData.GetCountries(), new ExpectedResult(0, null))
                .SetName("ShouldSortBy0CountiresHighest_Success");

            yield return new TestCaseData(DateTime.Now, null, 
                    VatRateTestData.GetCountries(), new ExpectedResult(0, null))
                .SetName("ShouldSortByNullCountiresHighest_Success");

            yield return new TestCaseData(DateTime.Now, 3, 
                    VatRateTestData.GetCountries(), new ExpectedResult(3, "ru"))
                .SetName("ShouldSortBy3CountiresHighest_Success");
            
            yield return new TestCaseData(DateTime.Now, 2, 
                    VatRateTestData.GetCountries(), new ExpectedResult(2, "ru"))
                .SetName("ShouldSortBy2CountiresHighest_Success");

            yield return new TestCaseData(DateTime.Now, 3, 
                    VatRateTestData.GetCountriesWithEffectiveFromPeriods(), new ExpectedResult(3, "ua"))
                .SetName("ShouldSortBy3CountiresWithMultiplePeriodsHighest_Success");
        }
    }
}