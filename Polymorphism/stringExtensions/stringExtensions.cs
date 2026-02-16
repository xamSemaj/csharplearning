using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Polymorphism.stringExtensions
{
    public static class StringExtensions
    {
        public static int CountLines(this string input) => input.Split(Environment.NewLine).Length;
    }
}
public static class ListExtensions
{
    public static List<int> TakeEverySecond(this List<int> input)
    {
        
       
        List<int> result = new List<int>();
        for (int i = 0; i < input.Count; i += 2)
        {
            if ( result[i] == 1 ) { input[i] = 1; }
            result.Add(input[i]);
        }

    

        return result;
    }
    
    
}