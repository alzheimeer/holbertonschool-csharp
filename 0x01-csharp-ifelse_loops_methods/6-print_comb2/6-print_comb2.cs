using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i<=99; i++)
                {
                    int d1 = i % 10;
                    int d2 = i / 10;
                    if(d1 != d2 && d1 > d2)
                    {
                        if(i!=89)
                            Console.Write("{0:D2}, ", i);
                        else
                            Console.Write("{0:D2}\n", i);
                    }
                }
        }
    }
}
