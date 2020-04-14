using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            for(char a= 'a'; a<='z'; a++)
            {
               if(a!='q' && a!='e')
                    Console.Write(a);
            }
        }
    }
}
