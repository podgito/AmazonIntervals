using AmazonianDates.Parsers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;

namespace AmazonianDates.Tests.Parsers
{
    [TestFixture]
    public class DayParserTest
    {

        IDateParser parser;

        [SetUp]
        public void Setup()
        {
            parser = new DayParser();
        }

        [Test]
        [TestCase("2017-01-01")]
        [TestCase("2017-2001-01")]
        [TestCase("2017-31-01")]
        [TestCase("2017-72-98")]
        public void IsMatchForOnlyFullDates(string dateString)
        {
            parser.IsMatch(dateString).ShouldBeTrue();
        }

        [Test]
        [TestCase("2017")]
        [TestCase("2017-04")]
        [TestCase("2017-W04")]
        [TestCase("2017-04-01-09")]
        [TestCase("2017-W04-WE ")]
        public void NotMatchForNonFullDates(string dateString)
        {
            parser.IsMatch(dateString).ShouldBeFalse();
        }

        [Test]
        [TestCase("2017-13-01")]
        public void ParsingInvalidDateThrowsException(string dateString)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => parser.Parse(dateString));
        }

        [Test]
        [TestCase("2017-01-23")]
        public void ParseValidDateMakesIntervalOfOneDay(string dateString)
        {
            parser.Parse(dateString).FromDateTime.ShouldBe(DateTime.Parse(dateString).Date);
            parser.Parse(dateString).ToDateTime.ShouldBe(DateTime.Parse(dateString).Date.AddDays(1));
        }

        


    }
}
