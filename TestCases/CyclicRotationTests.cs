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
    public class CyclicRotationTests
    {
        [TestMethod]
        [DataRow(new int[]{3, 8, 9, 7, 6},3,new int[]{9,7,6,3,8})]
        public void RotationTest(int[] A, int k, int[] expected)
        {
            CyclicRotation rotation = new CyclicRotation();
            var result = rotation.Rotate(A, k);
            for(int index = 0;index < A.Length;index++)
            {
                Assert.AreEqual(expected[index], result[index]);
            }
            
        }
    }
}
