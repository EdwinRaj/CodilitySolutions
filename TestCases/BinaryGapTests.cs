using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace TestCases
{
    [TestClass]
    public class BinaryGapTests
    {
        [TestMethod]
        //[DataRow(1,0)]
        //[DataRow(4, 0)]
        //[DataRow(5, 1)]
        //[DataRow(7, 0)]
        //[DataRow(8, 0)]
        //[DataRow(9, 2)]
        //[DataRow(10, 1)]
        //[DataRow(1041,5)]
        [DataRow(1162,3)]
        public void GapTests(int input, int output)
        {
            BinaryGap gap = new BinaryGap();
            var result = gap.Calculate(input);
            Assert.AreEqual(output, result);
        }
    }
}
