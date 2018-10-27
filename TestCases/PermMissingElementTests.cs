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
    public class PermMissingElementTests
    {
        [TestMethod]
        [DataRow(new int[] { 1,2,3,4,6},5)]
        [DataRow(new int[] { 1, 2, 3, 8, 6,7, 5 }, 4)]
        public void TestMissingElements(int[] data,int expected)
        {
            PermMissingElement element = new PermMissingElement();
            var result  = element.solution(data, data.Length);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 6 }, 5)]
        [DataRow(new int[] { 1, 2, 3, 8, 6, 7, 5 }, 4)]
        public void TestMissingElementsXor(int[] data, int expected)
        {
            PermMissingElement element = new PermMissingElement();
            var result = element.solutionXor(data, data.Length);
            Assert.AreEqual(expected, result);
        }
    }
}
