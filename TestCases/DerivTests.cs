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
    public class DerivTests
    {
        [TestMethod]
        [DataRow(new int[]{1, 3, 6, 4, 1, 2},5)]
        [DataRow(new int[] { 1, 2,3 }, 4)]
        [DataRow(new int[] { -1,-3,-4 }, 1)]
        public void Tests(int[] input, int expectedResult)
        {
            Deriv d = new Deriv();
            var result = d.MinNextSmallPositive(input);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
