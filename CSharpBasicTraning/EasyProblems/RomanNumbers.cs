namespace CSharpBasicTraning.EasyProblems
{
    internal class RomanNumbers
    {
        public static int RomanToInt(string s) //
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            Dictionary<char, int> valuePairs = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };

            char[] chars = s.ToCharArray();
            int charsLength = chars.Length;
            int sum = 0;

            for (int i = 0; i < charsLength; i++)
            {
                if (i < charsLength - 1 && valuePairs[chars[i]] < valuePairs[chars[i+1]])
                {
                    sum -= valuePairs[chars[i]];
                }
                else
                {
                    sum += valuePairs[chars[i]];
                }
            }
            GC.Collect();

            return sum;
        }
    }
}
