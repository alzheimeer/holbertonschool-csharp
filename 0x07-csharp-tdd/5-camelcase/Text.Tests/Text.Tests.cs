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
            string s = "";
            
            int result = Str.CamelCase(s);

            Assert.AreEqual(0, result);
        }
        [Test]
        public void xtwo()
        {
            string s = null;
            
            int result = Str.CamelCase(s);

            Assert.AreEqual(0, result);
        }
        [Test]
        public void xping()
        {
            string s = "papaNoelEsUnZombie";
            
            int result = Str.CamelCase(s);

            Assert.AreEqual(5, result);
        }
    }
}