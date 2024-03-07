using CSharpBasicTraning.EasyProblems;

namespace CSharpBasicTraning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] result = TwoSum.MakeTheSumLinear([5, 5, 12, 43, 29, 35], 55);

            Console.WriteLine(result.Length != 0 ? $"The result is: [{result[0]}, {result[1]}]." : "The target was not reached.");
            */

            /*
            int result = RomanNumbers.RomanToInt("MCMXCIV");
            Console.WriteLine(result);
            */

            /*
            bool result = PalindromeInt.IsPalindromeNoString(-22);
            Console.WriteLine(result ? "The number is a Palindrome." : "The number is not a Palindrome.");
            */

            /*
            string result = CommonPrefix.LongestCommonPrefix(["flower", "flow", "flight"]);
            Console.WriteLine($"The longest prefix found is: {result}.");
            */

            bool result = ValidParentheses.IsValid("()");
            Console.WriteLine("The given parentheses {0}.", result ? "is valid" : "is not valid");
        }
    }
}
