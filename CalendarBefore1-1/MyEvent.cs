using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBefore1_1
{
    [Serializable]
    internal class MyEvent
    {
        public Guid Id;
        public string Text;
        public DateTime Date;

        public MyEvent() { }

        public MyEvent(string text, DateTime date)
        {
            Text = text;
            Date = date;

            Id = Guid.NewGuid();
        }

        public MyEvent(Guid id, string text, DateTime date)
        {
            Id = id;
            Text = text;
            Date = date;
        }
    }
}
