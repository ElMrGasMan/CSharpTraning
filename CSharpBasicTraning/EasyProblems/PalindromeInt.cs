namespace CSharpBasicTraning.EasyProblems
{
    internal class PalindromeInt
    {
        public static bool IsPalindromeString(int x)
        {
            if (x < 0 || (x != 0 && x % 10 == 0))
            {
                return false;
            }

            string stringNumb = x.ToString();
            char[] arr = stringNumb.ToCharArray();
            Array.Reverse(arr);
            string? reversedStr = new(arr);


            return reversedStr == stringNumb;
        }

        public static bool IsPalindromeString2(int x) //Another way to do it, prolly faster but doesn't seem like it.
        {
            string numberString = x.ToString();
            string reversedString = "";

            for (int i = numberString.Length - 1; i >= 0; i--)
            {
                reversedString += numberString[i];
            }

            return numberString == reversedString;
        }

        public static bool IsPalindromeNoString(int x) //Using the module operator to extract every digit into another int.
        {
            if (x < 0 || (x != 0 && x % 10 == 0))
            {
                return false;
            }

            long reversedInt = 0;
            long y = x;
            int digit;

            while (y != 0)
            {
                digit = (int)y % 10;
                y /= 10;
                reversedInt = reversedInt * 10 + digit;
            }

            return reversedInt == x;
        }
    }
}
