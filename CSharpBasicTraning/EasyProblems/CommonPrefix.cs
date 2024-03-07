using System.Text;

namespace CSharpBasicTraning.EasyProblems
{
    internal class CommonPrefix
    {
        public static string LongestCommonPrefixVertical(string[] strs) 
        {
            if (strs.Length == 0) return "";

            StringBuilder sb = new();
            string baseStr = strs.First();

            for (int i = 0; i < baseStr.Length; i++)
            {
                foreach (string word in strs.Skip(0))
                {
                    if (i == word.Length || word[i] != baseStr[i]) return sb.ToString();
                }

                sb.Append(baseStr[i]);
            }

            return sb.ToString();

        }


        public static string LongestCommonPrefix(string[] strs) 
        {
            if (strs.Length == 0) return "";

            Array.Sort(strs);

            StringBuilder sb = new();
            string firstStr = strs.First();
            string lastStr = strs.Last();

            for (int i = 0; i < Math.Min(firstStr.Length, lastStr.Length); i++)
            {
                if (firstStr[i] != lastStr[i]) return firstStr[..i];
               
                sb.Append(firstStr[i]);
            }

            return sb.ToString();
        }
    }
}
