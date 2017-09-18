using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
