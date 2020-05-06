using System;

namespace Text
{
    ///<summary>Each word begins with a capital letter except the first word</summary>
    public class Str
    {
        /// <summary>how many words are in a string</summary>
        /// <param name="s">string</param>
        /// <returns> number of words in s</returns>
        public static int CamelCase(string s)
        {
            if (s == "" || s == null)
                return 0;
            int count = 0;
            for (int i = 0; i <= s.Length-1; i++)
            {
                if (Char.IsUpper(s[i]))
                    count++;
            }
            return count + 1;
        }
    }
}
