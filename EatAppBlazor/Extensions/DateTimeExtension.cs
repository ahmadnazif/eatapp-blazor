using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatAppBlazor.Extensions
{
    public static class DateTimeExtension
    {
        public static string ToDbDateTimeString(this DateTime date)
        {
            return date.ToString("yyyy-MM-dd HH:mm:dd");
        }
    }
}
