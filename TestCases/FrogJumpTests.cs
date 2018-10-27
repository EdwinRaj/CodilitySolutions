using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions;

namespace TestCases
{
    [TestClass]
    public class FrogJumpTests
    {
        [TestMethod]
        [DataRow(10,85,30,3)]
        [DataRow(1, 1, 2, 0)]
        [DataRow(1, 3, 2, 1)]
        public void Tests(int x, int y, int d, int expected)
        {
            FrogJump jump = new FrogJump();
            var result = jump.Solution(x, y, d);
            Assert.AreEqual(expected, result);
        }
    }
}
