using System;

public class NullCheck
{
    //Not placing the ? after string was making the test case always be true, as per rider help message
    public static string String(string? test)
    {
        if (test == null)
        {
            return " ";
        }
        else return test;
    }
}