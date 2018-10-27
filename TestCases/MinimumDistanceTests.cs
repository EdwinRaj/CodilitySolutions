using System;
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
    public class MinimumDistanceTests
    {
        [TestMethod]
        [DataRow(new int[] { 7, 21, 3, 42, 3, 7 },0)]
        [DataRow(new int[] { 8,24,3,20,1,17 }, 2)]
        [DataRow(new int[] { 8 }, 0)]
        [DataRow(new int[] { 2,8,9,10 }, 1)]
        [DataRow(new int[] { 2, 8, 10,11 }, 1)]
        public void Tests(int[] input, int expectedResult)
        {
            MinimumDistance distance = new MinimumDistance();
            var result = distance.Solution(input);
            Assert.AreEqual(expectedResult, result);

        }
    }
}
