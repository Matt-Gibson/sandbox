using System;

public class NullCheck
{
    public static string String(string test)
    {
        if (test == null)
        {
            return " ";
        }
        else return test;
    }
}