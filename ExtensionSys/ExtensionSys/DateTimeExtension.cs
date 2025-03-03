using System;

namespace ExtensionSys
{
    public static class DateTimeExtension
    {
        // Check if the DateTime is a weekend
        public static bool IsWeekend(this DateTime dateTime)
        {
            return dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday;
        }

        // Check if the DateTime is a weekday
        public static bool IsWeekday(this DateTime dateTime)
        {
            return !dateTime.IsWeekend();
        }

        // Get the start of the day (midnight)
        public static DateTime StartOfDay(this DateTime dateTime)
        {
            return dateTime.Date;
        }

        // Get the end of the day (last moment before midnight)
        public static DateTime EndOfDay(this DateTime dateTime)
        {
            return dateTime.Date.AddDays(1).AddTicks(-1);
        }

        // Get the start of the month
        public static DateTime StartOfMonth(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1);
        }

        // Get the end of the month
        public static DateTime EndOfMonth(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month)).EndOfDay();
        }

        // Get the start of the year
        public static DateTime StartOfYear(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, 1, 1);
        }

        // Get the end of the year
        public static DateTime EndOfYear(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, 12, 31).EndOfDay();
        }

        // Calculate age based on a given date
        public static int CalculateAge(this DateTime birthDate, DateTime? referenceDate = null)
        {
            var today = referenceDate ?? DateTime.Today;
            var age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}