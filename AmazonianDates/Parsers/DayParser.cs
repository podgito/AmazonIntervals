using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonianDates.Parsers
{
    public class DayParser : IDateParser
    {
        public bool IsMatch(string amazonDate)
        {
            var isMatch = false;
            var components = amazonDate.Split('-');

            if (components.Length == 3) //May continue
            {
                isMatch = components.All(IsInteger);
            }

            return isMatch;
        }

        public Interval Parse(string amazonDate)
        {
            DateTime dateTime;
           var isDateTimeValid = DateTime.TryParse(amazonDate, out dateTime);

            if (!isDateTimeValid) throw new ArgumentOutOfRangeException("amazonDate");

            return new Interval(dateTime.Date, dateTime.Date.AddDays(1));
        }
        private bool IsInteger(string someString)
        {
            var value = 0;
            return int.TryParse(someString, out value);
        }
    }
}
