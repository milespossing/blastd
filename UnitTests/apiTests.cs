using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using blastd;

namespace UnitTests
{
    [TestClass]
    public class apiTests
    {
        [TestMethod]
        public void GetTest()
        {
            Requester r = new Requester();
            List<string> str = r.GetValues().Result;
            List<string> expected = new List<string>(){"value1","value2"};
            TestTools.AssertAreEqual(expected, str);
        }
    }
}
