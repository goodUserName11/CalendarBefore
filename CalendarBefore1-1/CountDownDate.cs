using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBefore1_1
{
    /// <summary>
    /// Класс для отсчета до даты
    /// </summary>
    class CountDownDate : MyEvent
    {
        public CountDownDate() : base()
        {

        }

        public CountDownDate(string text, DateTime date) : base(text, date)
        {

        }

        public CountDownDate(Guid id, string text, DateTime date) : 
            base(id, text, date)
        {

        }

        /// <summary>
        /// Возвращает промежуток времени, оставшийся до даты в экземпляре класса
        /// </summary>
        /// <param name="currentDateTime">Время, от которого ведется отсчет</param>
        /// <returns>Специальный промежуток времени с месяцами, днями и часами</returns>
        public MyTimeSpan TillCurrentDateRemained(DateTime currentDateTime)
        {
            return DateTimeCustoms.CutomMinus(this.Date, currentDateTime);
        }

        /// <summary>
        /// возвращает промежуток времени между указанными датами
        /// </summary>
        /// <param name="neededDate">Время, до которого ведется отсчет</param>
        /// <param name="currentDateTime">Время, от которого ведется отсчет</param>
        /// <returns>Специальный промежуток времени с месяцами, днями и часами</returns>
        public static MyTimeSpan TillCurrentDateRemained(DateTime currentDateTime, DateTime neededDate)
        {
            return DateTimeCustoms.CutomMinus(currentDateTime, neededDate);
        }
    }
}
