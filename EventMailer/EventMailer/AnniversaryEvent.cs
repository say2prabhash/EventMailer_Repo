using EventMailer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMailer
{
    class AnniversaryEvent:IEvents
    {
        DataRetriever retriever;
        public AnniversaryEvent()
        {
            retriever = new DataRetriever();
        }
        public void EventFirer()
        {
            retriever.RetrieveAnniversaryData();
        }
    }
}
