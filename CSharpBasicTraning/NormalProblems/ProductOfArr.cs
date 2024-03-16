namespace CSharpBasicTraning.NormalProblems
{
    internal class ProductOfArr
    {
        public static int[] ProductExceptSelfOwnSolution(int[] nums)
        {
            int n = nums.Length;
            int[] answer = new int[n];
            int[] prefixes = new int[n];
            int[] suffixes = new int[n];

            prefixes[0] = nums[0];
            suffixes[n - 1] = nums[n - 1];

            for (int i = 1; i < n; i++)
            {
                prefixes[i] = prefixes[i - 1] * nums[i];
                suffixes[n - i - 1] = suffixes[n - i] * nums[n - i - 1];
            }

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    answer[i] = suffixes[i + 1];
                }
                else if (i == n - 1)
                {
                    answer[i] = prefixes[i - 1];
                }
                else
                {
                    answer[i] = prefixes[i - 1] * suffixes[i + 1];
                }
            }

            return answer;
        }

        /// <summary>
        /// The above solution ("ProductExceptSelfOwnSolution") combined with the solution 
        /// below ("ProductExceptSelfAnotherWay"), making this one more optimized.
        /// </summary>
        public static int[] ProductExceptSelfOwnSolOptimized(int[] nums)
        {
            int n = nums.Length;
            int[] answer = new int[n];
            int[] prefixes = new int[n];
            int[] suffixes = new int[n];

            prefixes[0] = 1;
            suffixes[n - 1] = 1;

            for (int i = 1; i < n; i++)
            {
                prefixes[i] = prefixes[i - 1] * nums[i - 1];
                suffixes[n - i - 1] = suffixes[n - i] * nums[n - i];
            }

            for (int i = 0; i < n; i++)
            {
                answer[i] = prefixes[i] * suffixes[i];
            }

            return answer;
        }

        public static int[] ProductExceptSelfAnotherWay(int[] nums)
        {
            int n = nums.Length;
            int[] answer = new int[n];
            int[] prefixes = new int[n];
            int[] suffixes = new int[n];

            prefixes[0] = 1;
            suffixes[n - 1] = 1;

            for (int i = 1; i < n; i++)
            {
                prefixes[i] = prefixes[i - 1] * nums[i - 1];
            }

            for (int i = n - 2; i >= 0; i--)
            {
                suffixes[i] = suffixes[i + 1] * nums[i + 1];
            }

            for (int i = 0; i < n; i++)
            {
                answer[i] = prefixes[i] * suffixes[i];
            }

            return answer;
        }
    }
}
