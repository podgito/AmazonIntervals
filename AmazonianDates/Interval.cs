using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonianDates
{
    /// <summary>
    /// Represents a time interval between one point in time and another
    /// </summary>
    public class Interval
    {
        public DateTime FromDateTime { get; protected set; }
        public DateTime ToDateTime { get; protected set; }

        public Interval(DateTime fromDateTime, DateTime toDateTime)
        {
            this.FromDateTime = fromDateTime;
            this.ToDateTime = toDateTime;
        }

        /// <summary>
        /// Creates a time interval from Amazon.Date slot type 
        /// <a href="https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/built-in-intent-ref/slot-type-reference#date">HERE</a>
        /// </summary>
        /// <param name="amazonDate">The Amazon.Date slot type value</param>
        /// <returns></returns>
        public static Interval FromAlexa(string amazonDate)
        {
            throw new NotImplementedException();
        }



    }
}
