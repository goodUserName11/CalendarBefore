using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBefore1_1
{
    /// <summary>
    /// Специальный временной промежуток
    /// (Месяцы, дни, часы)
    /// </summary>
    public class MyTimeSpan
    {
        int _months;
        int _days;
        int _hours;

        /// <summary>
        /// Показывает было ли переполнение месяца и с какой стороны
        /// </summary>
        public int Years;

        public MyTimeSpan()
        {
        }

        public MyTimeSpan(int months, int days, int hours)
        {
            Months = months;
            Days = days;
            Hours = hours;
        }

        public int Months 
        { 
            get => _months;

            set 
            {
                //if (Math.Abs(value) > 12)
                //    throw new ArgumentException("months cannot be more then 12","value");
                
                _months = value; 
            }
        }
        public int Days
        {
            get => _days;

            set
            {
                if (Math.Abs(value) > 31)
                    throw new ArgumentException("days cannot be more then 31", "value");

                _days = value;
            } 
        }
        public int Hours
        {
            get => _hours;

            set
            {
                if (Math.Abs(value) > 24)
                    throw new ArgumentException("hours cannot be more then 24", "value");

                _hours = value;
            }
        }

        public static MyTimeSpan operator +(MyTimeSpan timeSpan1, MyTimeSpan timeSpan2)
        {
            int month = timeSpan1.Months + timeSpan2.Months;
            int day = timeSpan1.Days + timeSpan2.Days;
            int hour = timeSpan1.Hours + timeSpan2.Hours;
            if (hour > 24)
            {
                day++;
                hour %= 25;
            }
            else if (hour < 0)
            {
                day--;
                hour *= -1;
            }
            if (day > 31)
            {
                month++;
                day %= 32;
            }
            else if (day < 0)
            {
                month--;
                day *= -1; ;
            }
            if (month < 0) { }
            {
                hour *= -1;
                day *= -1;
            }

            return new MyTimeSpan(month % 13, day, hour);
        }

        public static MyTimeSpan operator -(MyTimeSpan timeSpan1, MyTimeSpan timeSpan2)
        {
            MyTimeSpan ts = new MyTimeSpan(-timeSpan2.Months, -timeSpan2.Days, -timeSpan2.Hours);

            return timeSpan1 + ts;
        }

        public static DateTime operator +(DateTime dateTime, MyTimeSpan timeSpan)
        {
            int year = dateTime.Year;
            int month = dateTime.Month + timeSpan.Months;
            int day = dateTime.Day + timeSpan.Days;
            int hour = dateTime.Hour + timeSpan.Hours;
            if (hour > 24)
            {
                day++;
                hour %= 25;
            }
            else if (hour < 0)
            {
                day--;
                hour *= -1;
            }
            if (day > 31)
            {
                month++;
                day %= 32;
            }
            else if (day < 0)
            {
                month--;
                day *= -1;
            }
            if (month > 12)
            {
                year++;
                month %= 12;
            }
            else if (month < 0) { }
            {
                year--;
                month *= -1;
            }

            return new DateTime(year, month, day, hour, 0, 0);
        }

        public static DateTime operator -(DateTime dateTime, MyTimeSpan timeSpan)
        {
            MyTimeSpan ts = new MyTimeSpan(-timeSpan.Months, -timeSpan.Days, -timeSpan.Hours);

            return dateTime + timeSpan;
        }

        public static DateTime operator +(MyTimeSpan timeSpan, DateTime dateTime)
        {
            return dateTime + timeSpan;
        }

        public override string ToString()
        {
            return $"{Months} мес, {Days} дн, {Hours} ч";
        }

    }
}
