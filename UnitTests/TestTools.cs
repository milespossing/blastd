using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    class TestTools
    {
        public static void AssertAreEqual<T>(IList<T> expected, IList<T> actual)
        {
            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count(); i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
