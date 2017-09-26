using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace EventMailer.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            EventFiring fire = new EventFiring();
            fire.FireTheEventInitiator();
        }
        [TestMethod]
        public void Test_For_Retreiving_Employee_Birthday_Data_From_Database()
        {
            Dictionary<string, Dictionary<string,string>> dict = new Dictionary<string,Dictionary<string,string>>();
            DataRetriever dataRetriever = new DataRetriever();
            dict=dataRetriever.RetrieveBirthdayData();
            bool check = dict.ContainsKey("16-06-1994");
            Assert.IsTrue(check);
        }
        [TestMethod]
        public void Test_For_Retreiving_Employee_Anniversary_Data_From_Database()
        {
            Dictionary<string, Dictionary<string, string>> dict = new Dictionary<string, Dictionary<string, string>>();
            DataRetriever dataRetriever = new DataRetriever();
            dict = dataRetriever.RetrieveAnniversaryData();
            bool check = dict.ContainsKey("03-07-2017");
            Assert.IsTrue(check);
        }
    }
}
