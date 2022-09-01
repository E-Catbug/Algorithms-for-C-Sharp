//It's not what it sounds like I swear!
//Created by Alexander Fields https://github.com/roku674

using System;

namespace Algorithms
{
    public static class DateManipulation
    {
        /// Extension method parsing a date string to a DateTime? <para/>
        /// <summary>
        /// </summary>
        /// <param name="dateTimeStr">The date string to parse</param>
        /// <param name="dateFmt">dateFmt is optional and allows to pass
        /// a parsing pattern array or one or more patterns passed
        /// as string parameters</param>
        /// <returns>Parsed DateTime or null</returns>
        public static DateTime? ToDate(this string dateTimeStr, params string[] dateFmt)
        {
            // example: var dt = "2011-03-21 13:26".ToDate(new string[]{"yyyy-MM-dd HH:mm",
            //                                                  "M/d/yyyy h:mm:ss tt"});
            // or simpler:
            // var dt = "2011-03-21 13:26".ToDate("yyyy-MM-dd HH:mm", "M/d/yyyy h:mm:ss tt");
            const System.Globalization.DateTimeStyles style = System.Globalization.DateTimeStyles.AllowWhiteSpaces;
            if (dateFmt == null)
            {
                System.Globalization.DateTimeFormatInfo dateInfo = System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat;
                dateFmt = dateInfo.GetAllDateTimePatterns();
            }
            DateTime? result = DateTime.TryParseExact(dateTimeStr, dateFmt, System.Globalization.CultureInfo.InvariantCulture,
                           style, out DateTime dt) ? dt : null as DateTime?;
            return result;
        }
    }
}