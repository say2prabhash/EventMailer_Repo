using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMailer
{
    public class EventFiring
    {
        public delegate void EventDelegate();
        BirthdayEvent birthday;
        AnniversaryEvent anniversary;
        public EventFiring()
        {
            birthday = new BirthdayEvent();
            anniversary = new AnniversaryEvent();
        }
        public void FireTheEventInitiator()
        {
            EventDelegate eventsManager = new EventDelegate(birthday.EventFirer);
            eventsManager += anniversary.EventFirer;
            while (true)
            {
                DateTime eventTime = DateTime.Now;
                int hour = eventTime.Hour;
                if(hour==6)
                {
                    eventsManager();
                }
            }
        }
    }
}
