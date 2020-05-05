using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>Tests Alz</summary>
    public class OperationsTests
    {
        [Test]
        public void positiveInt()
        {
            int result = Operations.Add(1, 9);

            Assert.AreEqual(10, result);
        }

        [Test]
        public void negativeInt()
        {
            int result = Operations.Add(2, -12);

            Assert.AreEqual(-10, result);
        }
        
        [Test]
        public void bothNegativeInt()
        {
            int result = Operations.Add(-10, -10);

            Assert.AreEqual(-20, result);
        }

        [Test]
        public void CeroInt()
        {
            int result = Operations.Add(0, -30);

            Assert.AreEqual(-30, result);
        }

         [Test]
        
        public void BothCeroInt()
        {
            int result = Operations.Add(0, 0);

            Assert.AreEqual(0, result);
        }
    }
}