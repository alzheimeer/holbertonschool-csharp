using System;
class Number
{
    public static int PrintLastDigit(int number)
    {
        int ud = number%10;
        if (ud < 0)
            ud = ud * -1;
        Console.Write(ud);
        return ud;
    }
}