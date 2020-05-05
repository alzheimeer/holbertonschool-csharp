using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>Tests Alz</summary>
    public class OperationsTests
    {
        
        [Test]
        public void maxpositive()
        {
            List<int> digits = new List<int> { 0, 9, -2, 3, 44, 5, 6, 7, 8, 1 }; 

            int result = Operations.Max(digits);

            Assert.AreEqual(44, result);
        }

        [Test]
        public void xempty()
        {
            List<int> nums = new List<int>();

            int max = Operations.Max(nums);
            Assert.AreEqual(0, max);
        }

        [Test]
        public void xnull()
        {
            List<int> nums = null;

            int max = Operations.Max(nums);
            Assert.AreEqual(0, max);
        }


    }
}