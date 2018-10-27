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
    public class TapeEquilibriumTests
    {
        [TestMethod]
        [DataRow(new int[] { 3,1,2,4,3},1)]
        [DataRow(new int[] { 1,5,7,10,3 }, 0)]
        public void Tests(int[] data, int expected)
        {
            TapeEquilibrium tp = new TapeEquilibrium();
            var result = tp.Solution(data, data.Length);
            Assert.AreEqual(expected, result);
        }
    }
}
