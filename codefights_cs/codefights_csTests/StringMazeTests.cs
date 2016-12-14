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
    public class StringMazeTests
    {
        [TestMethod()]
        [Timeout(4000)]
        public void stringMazeTest1()
        {
            Assert.AreEqual(StringMaze.stringMaze("able"), 2);
        }


        [TestMethod()]
        [Timeout(4000)]
        public void stringMazeTest2()
        {
            Assert.AreEqual(StringMaze.stringMaze("aced"), -1);
        }


        [TestMethod()]
        [Timeout(4000)]
        public void stringMazeTest3()
        {
            Assert.AreEqual(StringMaze.stringMaze("uber"), 2);
        }


        [TestMethod()]
        [Timeout(4000)]
        public void stringMazeTest4()
        {
            Assert.AreEqual(StringMaze.stringMaze("fffff"), 4);
        }


        [TestMethod()]
        [Timeout(4000)]
        public void stringMazeTest5()
        {
            Assert.AreEqual(StringMaze.stringMaze("ghghgh"), 3);
        }


        [TestMethod()]
        [Timeout(4000)]
        public void stringMazeTest6()
        {
            Assert.AreEqual(StringMaze.stringMaze("ccdhdbhdc"), -1);
        }


        [TestMethod()]
        [Timeout(4000)]
        public void stringMazeTest7()
        {
            Assert.AreEqual(StringMaze.stringMaze("ccdhdbhcd"), 8);
        }


        [TestMethod()]
        [Timeout(4000)]
        public void stringMazeTest8()
        {
            Assert.AreEqual(StringMaze.stringMaze("aesvdjjfrizknthijnacdkz"), 10);
        }
    }
}