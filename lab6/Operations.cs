using System.Linq;

namespace lab6
{
    public static class Operations
    {
        public static string[] LengthAbove3(this string[] str)
        {
            return str.Where(s => s.Length >= 3).ToArray();
        }
        public static string[] LineIsSentence(this string[] str)
        {
            return str.Where(s => char.IsUpper(s[0]) && s.EndsWith(".")).ToArray();
        }
        public static string[] ContainsSpecialCharacters(this string[] str)
        {
            char[] specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,".ToCharArray();
            return str.Where(s => s.IndexOfAny(specialChar) > 0).ToArray();
        }

        public static string[] SortAsc(this string[] str)
        {
            return str.OrderBy(s => s.Length).ToArray();
        }
        public static string[] SortDesc(this string[] str)
        {
            return str.OrderByDescending(s => s.Length).ToArray();
        }

        public static string[] ToLowercase(this string[] str)
        {
            return str.Select(s => s.ToLower()).ToArray();
        }
        public static string[] ToUppercase(this string[] str)
        {
            return str.Select(s => s.ToUpper()).ToArray();
        }
        public static string[] ReplaceSpaceByUnderscore(this string[] str)
        {
            return str.Select(s => s.Replace(' ', '_')).ToArray();
        }

        public static bool[] IsLengthAbove3(this string[] str)
        {
            return str.Select(s => s.Length >= 3).ToArray();
        }
        public static bool[] IsASentence(this string[] str)
        {
            return str.Select(s => char.IsUpper(s[0]) && s.EndsWith(".")).ToArray();
        }
        public static bool[] HasSpecialCharacters(this string[] str)
        {
            char[] specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,".ToCharArray();
            return str.Select(s => s.IndexOfAny(specialChar) > 0).ToArray();
        }

        public static string[] GetFirstWord(this string[] str)
        {
            return str.Select(s => s.Split(' ').First()).ToArray();
        }
        public static string[] GetLastWord(this string[] str)
        {
            return str.Select(s => s.Split(' ').Last()).ToArray();
        }
        public static int[] CountWords(this string[] str)
        {
            return str.Select(s => s.Split(' ').Count()).ToArray();
        }

        public static string[] IntToStringArray(this int[] objects)
        {
            return objects.Select(o => o.ToString()).ToArray();
        }

        public static string[] BoolToStringArray(this bool[] objects)
        {
            return objects.Select(o => o.ToString()).ToArray();
        }
    }
}
