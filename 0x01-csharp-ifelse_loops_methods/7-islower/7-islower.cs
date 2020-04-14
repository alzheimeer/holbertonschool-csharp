using System;

class Character
{
    public static bool IsLower(char c)
    {
        if(c >= 'a' && c <= 'z')
            return true;
        else
            return false;
    }
}
