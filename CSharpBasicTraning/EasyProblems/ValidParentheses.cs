using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicTraning.EasyProblems
{
    internal class ValidParentheses
    {
        public static bool IsValid(string str) 
        {
            Stack<char> stack = new();

            if (string.IsNullOrEmpty(str)) return false;

            foreach (char symbol in str)
            {
                if (symbol == '{') stack.Push('}');
                
                else if (symbol == '(') stack.Push(')');
                
                else if (symbol == '[') stack.Push(']');
                
                else if (stack.Count == 0 || stack.Pop() != symbol) return false;
            }

            return stack.Count == 0;
        }
    }
}
