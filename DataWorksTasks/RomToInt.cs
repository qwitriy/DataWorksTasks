using System;
using System.Collections.Generic;

namespace DataWorksTasks
{
    public static class RomToInt
    {
        public static int Convert(string s)
        {
            var result = 0;

            var romanNumeralDictionary = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            for (var i = 0; i < s.Length; i++)
            {
                var a = romanNumeralDictionary[s[i]];

                if (i + 1 < s.Length)
                {
                    var b = romanNumeralDictionary[s[i + 1]];

                    if (a >= b)
                    {
                        result += a;
                    }
                    else
                    {
                        result += b - a;
                        i++;
                    }
                }
                else
                {
                    result += a;
                    i++;
                }
            }
            
            return result;
        }
    }
}