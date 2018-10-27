using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace TestCases
{
    [TestClass]
    public class WholeSquareTests
    {
        [TestMethod]
        [DataRow(4,17,3)]
        [DataRow(-10000,0,0)]
        [DataRow(1,100, 10)]
        [DataRow(1, 10000, 100)]
        public void Tests(int a, int b, int expectedResult)
        {
            WholeSquare square = new WholeSquare();
            var result = square.Solution(a, b);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
