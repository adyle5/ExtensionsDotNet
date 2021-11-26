// Copyright © 2021 Adrian Gabor
// Refer to license.txt for usage and permission information 

using System;
using System.Globalization;
using System.Threading;

namespace Extensions.net
{
    public static class DateExtensions
    {
        /// <summary>
        /// Returns true if the current year of the extended DateTime is a leap year and false if it isn't.
        /// Maps to DateTime.IsLeapYear
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool IsLeapYearExt(this DateTime date) => DateTime.IsLeapYear(date.Year);

        /// <summary>
        /// Returns a boolean vlaue indicating if the current month of the extended DateTime is a leap month.
        /// Uses the current culture of the machine.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        //public static bool IsLeapMonthExt(this DateTime date) => Thread.CurrentThread.CurrentCulture.Calendar.IsLeapMonth(date.Year, date.Month);

        /// <summary>
        /// Returns a boolean vlaue indicating if the current day of the extended DateTime is a leap day.
        /// Uses the current culture of the machine.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool IsLeapDayExt(this DateTime date) => Thread.CurrentThread.CurrentCulture.Calendar.IsLeapDay(date.Year, date.Month, date.Day);

        /// <summary>
        /// Returns the number of days in the month of the extended DateTime.
        /// Maps to DateTime.DaysInMonth
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static int DaysInMonthExt(this DateTime date) => DateTime.DaysInMonth(date.Year, date.Month);

        /// <summary>
        /// Returns which week of the year in the current culture the extended date time belongs to.
        /// Takes two optional paramaters: 
        /// calendarWeekRule used to determine the first week of the year and 
        /// firstDayOfWeek used to determine what the first day of the year is. 
        /// Defaulted values are CalendarWeekRule.FirstDay and DayOfWeek.Sunday
        /// Uses the current culture of the machine.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="weekRule"></param>
        /// <param name="firstDayOfWeek"></param>
        /// <returns></returns>
        public static int WeekOfYearExt(this DateTime date, CalendarWeekRule calendarWeekRule = CalendarWeekRule.FirstDay, DayOfWeek firstDayOfWeek = DayOfWeek.Sunday) => Thread.CurrentThread.CurrentCulture.Calendar.GetWeekOfYear(date, calendarWeekRule, firstDayOfWeek);
    }
}
