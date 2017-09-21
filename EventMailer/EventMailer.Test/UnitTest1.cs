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
        public void Test_For_Retreiving_Employee_Data_From_Database()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            DataRetriever dataRetriever = new DataRetriever();
            dict=dataRetriever.RetrieveBirthdayData();
            bool check = dict.ContainsKey("Prabhash");
            Assert.IsTrue(check);
        }
    }
}
