using AmazonianDates;
using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonianDates.Tests
{
    [TestFixture]
    public class DayIntervalsFromDateInstantsTest
    {

        [Test]
        [TestCase("2017-01-01", 2017,01, 01)]
        public void ShouldMapToDayIntervalMidnightToMidnight(string alexaDateTimeString, int expectedYear, int expectedMonth, int expectedDay)
        {
            //Arrange
            var expectedFromDateTime = new DateTime(expectedYear, expectedMonth, expectedDay);
            var expectedToDateTime = new DateTime(expectedYear, expectedMonth, expectedDay).AddDays(1);

            //Act
            var interval = Interval.FromAlexa(alexaDateTimeString);

            //Assert
            interval.FromDateTime.ShouldBe(expectedFromDateTime);
            interval.ToDateTime.ShouldBe(expectedToDateTime);

        }

    }
}
