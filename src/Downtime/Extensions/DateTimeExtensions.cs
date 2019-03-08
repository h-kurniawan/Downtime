using System;
using System.Globalization;

namespace Downtime.Extensions
{
    public static class DateTimeExtensions
    {
        public static string To8601(this DateTimeOffset dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd'T'HH:mm:ss", CultureInfo.InvariantCulture);
        }
    }
}
