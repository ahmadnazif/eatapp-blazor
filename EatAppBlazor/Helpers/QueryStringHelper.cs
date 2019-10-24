using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatAppBlazor.Helpers
{
    public class QueryStringHelper
    {
        public static string GetValue(Uri uri, string queryString)
        {
            if (QueryHelpers.ParseQuery(uri.Query).TryGetValue(queryString, out var value))
                return value.First();

            return null;
        }
    }
}
