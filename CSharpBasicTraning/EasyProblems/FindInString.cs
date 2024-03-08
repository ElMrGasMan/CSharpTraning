using System.Text.RegularExpressions;

namespace CSharpBasicTraning.EasyProblems
{
    internal class FindInString
    {
        public static int StrStrRegex(string haystack, string needle) 
        {
            string pattern = needle;
            Regex regex = new(pattern);
            Match match = regex.Match(haystack);

            if (!match.Success)
            {
                return -1;
            }

            return match.Index;
        }

        public static int StrStr(string haystack, string needle) 
        {
            int lengthHay = haystack.Length;
            int lengthNeed = needle.Length;

            for (int i = 0; i < lengthHay; i++)
            {
                if (i + needle.Length > haystack.Length) break;

                for (int j = 0; j < lengthNeed && j+i < lengthHay; j++)
                {
                    if (needle[j] != haystack[i+j]) break;
                    if (j == lengthNeed - 1) return i;
                }
            }

            return -1;
        }
    }
}
