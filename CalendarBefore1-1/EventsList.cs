using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBefore1_1
{
    [Serializable]
    class EventsList
    {
        public List<MyEvent> EventList;
        
        public EventsList()
        {
            EventList = new List<MyEvent>();
        }

        public EventsList(IEnumerable<MyEvent> events)
        {
            EventList = new List<MyEvent>(events);
        }
    }
}
