using Microsoft.VisualStudio.TestTools.UnitTesting;
using codefights_cs;

namespace codefights_csTests
{
    [TestClass()]
    public class HolidayBreakTests
    {
        [TestMethod()]
        public void test1()
        {
            Assert.AreEqual(HolidayBreak.holidayBreak(2016), 11);
        }

        [TestMethod()]
        public void test2()
        {
            Assert.AreEqual(HolidayBreak.holidayBreak(2019), 16);
        }

        [TestMethod()]
        public void test3()
        {
            Assert.AreEqual(HolidayBreak.holidayBreak(2017), 10);
        }

        [TestMethod()]
        public void test4()
        {
            Assert.AreEqual(HolidayBreak.holidayBreak(2018), 11);
        }

        [TestMethod()]
        public void test5()
        {
            Assert.AreEqual(HolidayBreak.holidayBreak(2020), 16);
        }

        [TestMethod()]
        public void test6()
        {
            Assert.AreEqual(HolidayBreak.holidayBreak(2021), 11);
        }

        [TestMethod()]
        public void test7()
        {
            Assert.AreEqual(HolidayBreak.holidayBreak(2022), 11);
        }

        [TestMethod()]
        public void test8()
        {
            Assert.AreEqual(HolidayBreak.holidayBreak(2023), 10);
        }

        [TestMethod()]
        public void test9()
        {
            Assert.AreEqual(HolidayBreak.holidayBreak(2024), 16);
        }

        [TestMethod()]
        public void test10()
        {
            Assert.AreEqual(HolidayBreak.holidayBreak(2025), 16);
        }
    }
}
