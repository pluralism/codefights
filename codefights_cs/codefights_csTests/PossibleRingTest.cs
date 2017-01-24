using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using codefights_cs;

namespace codefights_csTests
{
    [TestClass()]
    public class PossibleRingTest
    {
        [TestMethod()]
        public void possibleRingTest1()
        {
            Assert.AreEqual(PossibleRing.possibleRing("C6H6"), 6);
        }
    }
}
