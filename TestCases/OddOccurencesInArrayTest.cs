using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases
{
    [TestClass]
    public class OddOccurencesInArrayTest
    {
        [TestMethod]
        [DataRow(new int[] { 9,3,9,3,9,7,9},7)]
        public void TestOddOccurence(int[] input, int expectedResult)
        {
            OddOccurencesInArray oc = new OddOccurencesInArray();
            var result = oc.Solution(input, input.Length);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
