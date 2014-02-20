using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CellarJournal.Utility
{
    public static class Helper
    {
        public static string[] GetEnumValues<T>(bool includeBlank)
        {
            List<string> values = new List<string>((Enum.GetValues(typeof(T)) as T[]).Select(t => t.ToString()));

            if (includeBlank)
            {
                values.Insert(0, string.Empty);
            }

            return values.ToArray();
        }
    }
}
