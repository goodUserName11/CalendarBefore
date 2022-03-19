using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBefore1_1
{
    [Serializable]
    class CountDownDateList
    {
        public List<CountDownDate> CountDownList;

        public CountDownDateList()
        {
            CountDownList = new List<CountDownDate>();
        }

        public CountDownDateList(IEnumerable<CountDownDate> countDowns)
        {
            CountDownList = new List<CountDownDate>(countDowns);
        }
    }
}