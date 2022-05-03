// https://www.geeksforgeeks.org/check-whether-two-strings-are-anagram-of-each-other/

using System;
using System.Collections.Generic;

namespace MmGuideAssignment
{
    public static class Anagram
    {
        public static void Test(string str1, string str2)
        {
            if (IsAnagram(str1, str2))
                Console.WriteLine($"[{str1}] and [{str2}] are anagram of each other");
            else
                Console.WriteLine($"[{str1}] and [{str2}] are not anagram of each other");
        }

        // Time Complexity : O(n)
        // Space Complexity : O(n)
        /// <summary>
        /// Case sensitive!
        /// </summary>
        /// <param name="a">First string</param>
        /// <param name="b">Second string</param>
        /// <returns>True if strings are anagram, false otherwise</returns>
        public static bool IsAnagram(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            var map = new Dictionary<char, int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (map.ContainsKey(a[i]))
                {
                    map[a[i]] = map[a[i]] + 1;
                }
                else
                {
                    map.Add(a[i], 1);
                }
            }

            for (int i = 0; i < b.Length; i++)
            {
                if (map.ContainsKey(b[i]))
                {
                    map[b[i]] = map[b[i]] - 1;
                }
            }

            var keys = map.Keys;

            foreach (char key in keys)
            {
                if (map[key] != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
