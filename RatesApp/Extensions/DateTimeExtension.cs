using System;

namespace RatesApp.Extensions
{
    internal static class DateTimeExtension
    {
        public static DateTime TryParseDateOrDefault(this string strDate, string dateFormat)
        {
            DateTime date = DateTime.MinValue;
            try
            {
                date = DateTime.ParseExact(strDate, dateFormat, System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                // ignored
            }

            return date;
        }
    }
}
