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
        DataAnalyzer analyzer;
        Dictionary<string, Dictionary<string,string>> employeeBirthdayInfo;
        public BirthdayEvent()
        {
            employeeBirthdayInfo = new Dictionary<string, Dictionary<string,string>>();
            retriever = new DataRetriever();
            analyzer = new DataAnalyzer();
        }
        public void EventFirer()
        {
            employeeBirthdayInfo = retriever.RetrieveBirthdayData();
            if(employeeBirthdayInfo!=null)
            {
                analyzer.BirtdayDataAnalyzer(employeeBirthdayInfo);
            }
        }
    }
}
