﻿using CSharpBasicTraning.EasyProblems;
using CSharpBasicTraning.NormalProblems;

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

            /*
            bool result = ValidParentheses.IsValid("()");
            Console.WriteLine("The given parentheses {0}.", result ? "is valid" : "is not valid");
            */

            /*
            int[] ints = [0];
            int result = DuplicatesRemoval.RemoveDuplicates(ints);
            Console.WriteLine(result);
            */

            /*
            int[] ints = [0, 1, 2, 2, 3, 0, 4, 2];
            int result = DuplicatesRemoval.DuplicatesDeletion(ints, 2);
            Console.WriteLine(result);
            */

            /*
            int result = FindInString.StrStrRegex("leetcode", "leeto");
            Console.WriteLine(result);
            */

            int[] result = ProductOfArr.ProductExceptSelfOwnSolOptimized([1, 2, 3, 4]);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
