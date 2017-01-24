using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace codefights_cs.Tests
{
    [TestClass()]
    public class BitWorkTests
    {
        [TestMethod()]
        public void bitWorkTest1()
        {
            Assert.AreEqual(BitWork.bitWork("SB16"), 65772);
        }

        [TestMethod()]
        public void bitWorkTest2()
        {
            Assert.AreEqual(BitWork.bitWork("|12<<3&510>>2SB10^6CB4"), 4195432);
        }

        [TestMethod()]
        public void bitWorkTest3()
        {
            Assert.AreEqual(BitWork.bitWork("<<8|9>>10^11"), 4299);
        }

        [TestMethod()]
        public void bitWorkTest4()
        {
            Assert.AreEqual(BitWork.bitWork("255"), 148);
        }

        [TestMethod()]
        public void bitWorkTest5()
        {
            Assert.AreEqual(BitWork.bitWork("1"), 51);
        }
    }
}