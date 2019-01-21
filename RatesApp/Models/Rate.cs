namespace RatesApp.Models
{
    public class Rate
    {
        public double Standard { get; set; }

        public static implicit operator double(Rate r)
        {
            return r.Standard;
        }
    }
}