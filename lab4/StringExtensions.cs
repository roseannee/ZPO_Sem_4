using System.Collections.Generic;
using System.Linq;

namespace lab4
{
    static class StringExtensions
    {
        public static string RegisterChange(this string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result += str.Substring(i, 1).ToUpper();
                }
                else
                {
                    result += str.Substring(i, 1).ToLower();
                }
            }

            return result;
        }

        public static string DeleteVowels(this string str)
        {
            string vowels = "aeiouyAEIOUY";
            str = new string(str.Where(c => !vowels.Contains(c)).ToArray());

            return str;
        }

        public static int[] WordsLength(this string str)
        {
            string[] words = str.Split(' ');
            int[] length = new int[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                length[i] = words[i].Length;
            }

            return length;
        }

        public static bool IsSentence(this string str)
        {
            if (str[0] < 'A' || str[0] > 'Z')
            {
                return false;
            }

            if (str[str.Length - 1] != '.')
            {
                return false;
            }

            return true;
        }

        public static IEnumerable<T> Mode<T>(this IEnumerable<T> input)
        {
            var dict = input.ToLookup(x => x);

            var maxCount = dict.Max(x => x.Count());

            return dict.Where(x => x.Count() == maxCount).Select(x => x.Key);
        }
    }
}
