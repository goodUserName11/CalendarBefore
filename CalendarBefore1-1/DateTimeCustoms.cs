using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBefore1_1
{
    public static class DateTimeCustoms
    {
        public static MyTimeSpan CutomMinus(this DateTime dateTime1, DateTime dateTime2)
        {
            int year = dateTime1.Year - dateTime2.Year;
            int month = dateTime1.Month - dateTime2.Month;
            int day = dateTime1.Day - dateTime2.Day;
            int hour = dateTime1.Hour - dateTime2.Hour;

            if (hour < 0)
            {
                day--;
                hour = 24 - Math.Abs(hour);
            }
            if (day < 0)
            {
                month--;
                day = 31 - Math.Abs(day);
            }
            if (month < 0)
            {
                year--;
                month = 12 - Math.Abs(month);
            }
            if (year <= 0)
            {
                hour = Math.Abs(hour);
                day = Math.Abs(day);
                month = Math.Abs(month);
            }
            else
            {
                hour = Math.Abs(hour);
                day = Math.Abs(day);
                month = Math.Abs(month);

                month += year * 12;
            }

            return new MyTimeSpan(month, day, hour) { Years = year };
        }
    }
}
