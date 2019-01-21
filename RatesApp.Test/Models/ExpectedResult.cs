namespace RatesApp.Test.Models
{
    public class ExpectedResult
    {
        public ExpectedResult(int ratesCount, string code)
        {
            RatesCount = ratesCount;
            FirstContryCode = code;
        }

        public int RatesCount { get; set; }

        public string FirstContryCode { get; set; }
    }
}