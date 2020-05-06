using NUnit.Framework;
using System.Globalization;

namespace Text.Tests
{
    [TestFixture]
    /// <summary>Tests Alz</summary>
    public class Tests
    {
        [Test]
        public void xempty()
        {
            string s = "";
            
            bool result = Str.IsPalindrome(s);

            Assert.AreEqual(true, result);
        }
        [Test]
        public void xis()
        {
            string s = "Racecar";
            
            bool result = Str.IsPalindrome(s);

            Assert.AreEqual(true, result);
        }
        [Test]
        public void xnotis()
        {
            string s = "A man, a plan, a canal: Panama.";
            
            bool result = Str.IsPalindrome(s);

            Assert.AreEqual(true, result);
        }
    }
}