// Copyright © 2022 Adrian Gabor
// Refer to license.txt for usage and permission information 

using System;
using Xunit;

namespace Extensions.net.core.tests.UnitTests
{
    public class DateExtensionsTests
    {
        [Fact]
        public void IsLeapYear()
        {
            DateTime dt = DateTime.Now;

            bool expected = DateTime.IsLeapYear(dt.Year);
            bool actual = dt.IsLeapYearExt();

            Assert.Equal(expected, actual);
        }

        //[Fact]
        //public void IsLeapMonth()
        //{
        //    DateTime dt = new DateTime(2020, 2, 20);

        //    Assert.True(dt.IsLeapMonthExt());
        //}

        [Fact]
        public void IsLeapDay()
        {
            DateTime dt = new (2020, 2, 29);
            Assert.True(dt.IsLeapDayExt());
        }

        [Fact]
        public void DaysInMonth()
        {
            DateTime dt = DateTime.Now;

            int expected = DateTime.DaysInMonth(dt.Year, dt.Month);
            int actual = dt.DaysInMonthExt();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WeekOfYear()
        {
            DateTime dt = new (2020, 1, 27);

            int expected = 5;
            int actual = dt.WeekOfYearExt();

            Assert.Equal(expected, actual);
        }
    }
}
