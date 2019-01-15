using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace GameOfCodes
{
    public static partial class SubsequenceFinder
    {
        public static string FindLongestSubsequence(string s, IEnumerable<string> d)
        {
            return d.OrderByDescending(word => word.Length).FirstOrDefault(word => word.IsSubsequenceOf(s));
        }

        public static bool IsSubsequenceOf(this string word, string s)
        {
            if (word.Length == 0)
                return true;
            var i = s.IndexOf(word[0]);
            if (i == -1)
            {
                return false;
            }
            else
            {
                return IsSubsequenceOf(word.Substring(1), s.Substring(i + 1));
            }
        }
    }
}
