using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("hasdur");
        var input  = Console.ReadLine();
        var chars = new Dictionary<char,int>();

        if (String.IsNullOrEmpty(input) || input.Length < 3)
        {
             returnFalse();
             return;
        }   

        for(int i = 0 ; i < input.Length ; i++)
        {
            char c = input[i];
            if (chars.ContainsKey(c))
                chars[c]++;
            else
                chars[c] = 1;
        }
        // check if at least one element with odd value and bigger than 1
        // for the ones that has something in center
        var centerChar = Char.MinValue;
        var allEvenOtherThanCenter = true;
        if (chars.Count(item => item.Value % 2 == 1) == 1)
        {
            centerChar = chars.First(item => item.Value % 2 == 1).Key;
        }
            
        //check for even ones
        foreach(var item in chars)
        {
            if (item.Key != centerChar)
            {
                if(item.Value % 2 != 0)
                {
                    allEvenOtherThanCenter = false;
                }
            }
        }
        if (allEvenOtherThanCenter)
        {
            returnTrue();
            return;
        }

        returnFalse();
    }

    private static void returnTrue()
    {
        Console.WriteLine("YES");
    }

    private static void returnFalse()
    {
        Console.WriteLine("NO");
    }
}
