using Microsoft.VisualStudio.TestTools.UnitTesting;
using codefights_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefights_cs.Tests
{
    [TestClass()]
    public class RangeConsecutiveXorTests
    {
        [TestMethod()]
        public void rangeConsecutiveXorTest1()
        {
            Assert.AreEqual(RangeConsecutiveXor.rangeConsecutiveXor(1, 5), 7);
        }


        [TestMethod()]
        public void rangeConsecutiveXorTest2()
        {
            Assert.AreEqual(RangeConsecutiveXor.rangeConsecutiveXor(3, 4), 4);
        }


        [TestMethod()]
        public void rangeConsecutiveXorTest3()
        {
            Assert.AreEqual(RangeConsecutiveXor.rangeConsecutiveXor(2, 6), 1);
        }


        [TestMethod()]
        public void rangeConsecutiveXorTest4()
        {
            Assert.AreEqual(RangeConsecutiveXor.rangeConsecutiveXor(5, 10), 4);
        }


        [TestMethod()]
        public void rangeConsecutiveXorTest5()
        {
            Assert.AreEqual(RangeConsecutiveXor.rangeConsecutiveXor(5, 5), 1);
        }


        [TestMethod()]
        public void rangeConsecutiveXorTest6()
        {
            Assert.AreEqual(RangeConsecutiveXor.rangeConsecutiveXor(1, 20), 22);
        }


        [TestMethod()]
        public void rangeConsecutiveXorTest7()
        {
            Assert.AreEqual(RangeConsecutiveXor.rangeConsecutiveXor(9, 53053), 53047);
        }


        [TestMethod()]
        public void rangeConsecutiveXorTest8()
        {
            Assert.AreEqual(RangeConsecutiveXor.rangeConsecutiveXor(35, 96607), 2);
        }
    }
}