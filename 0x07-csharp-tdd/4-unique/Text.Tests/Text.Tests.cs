using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    /// <summary>Tests Alz</summary>
    public class Tests
    {
        [Test]
        public void xfour()
        {
            string s = "ababc";
            
            int result = Str.UniqueChar(s);

            Assert.AreEqual(4, result);
        }
        [Test]
        public void xempty()
        {
            string s = "";
            
            int result = Str.UniqueChar(s);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void xone()
        {
            string s = "d";
            
            int result = Str.UniqueChar(s);

            Assert.AreEqual(0, result);
        }
        [Test]
        public void xnone()
        {
            string s = "ddggttrrffttffddgg";
            
            int result = Str.UniqueChar(s);

            Assert.AreEqual(-1, result);
        }
        [Test]
        public void xnull()
        {
            string s = null;
            
            int result = Str.UniqueChar(s);

            Assert.AreEqual(-1, result);
        }
    }
}