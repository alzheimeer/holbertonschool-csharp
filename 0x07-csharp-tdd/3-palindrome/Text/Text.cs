using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Text
{
    ///<summary>method verified palindrome</summary>
    public class Str
    {
        /// <summary>Max integer</summary>
        /// <param name="s">string</param>
        /// <returns>True if string is a palindrome, False if it’s not</returns>

        public static bool IsPalindrome(string s)
        {
            string s2 = s.ToLower();
            s2 = Regex.Replace(s2, "[:;,. \t\n\r]", "");
            int Length = s2.Length - 1;
            string reverse = "";  

            while(Length>=0)  
            {  
                reverse = reverse + s2[Length];  
                Length--;  
            }
            if (s2 == reverse)
                return true;
            else
                return false;
        }
    }
}
