using EventMailer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMailer
{
    class BirthdayEvent:IEvents
    {
        DataRetriever retriever;
        public BirthdayEvent()
        {
            retriever = new DataRetriever();
        }
        public void EventFirer()
        {
            retriever.RetrieveBirthdayData();
        }
    }
}
