using System;

namespace Text
{
    ///<summary>method char non repeating</summary>
    public class Str
    {
        /// <summary>non repeating</summary>
        /// <param name="s">string</param>
        /// <returns> index of first non-repeating character or -1 if there is no non-repeating</returns>
        public static int UniqueChar(string s)
        {
            if (s == null)
                return -1;
            s = s.ToLower();
            char[] arr = s.ToCharArray();
            int c;
            for(int i=0; i <= arr.Length-1;i++)
            {
                c = 0;
                for(int j=0; j <= arr.Length-1;j++)
                {
                    if (i != j)
                        if(arr[i] == arr[j])
                            c += 1;                    
                }
                if (c == 0)
                    return i;
            }
            return -1;
        }
    }
}
