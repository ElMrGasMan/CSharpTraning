namespace CSharpBasicTraning.EasyProblems
{
    internal class TwoSum
    {
        public static int[] MakeTheSumQuadratic(int[] nums, int target)
        {
            int arrLenght = nums.Length;

            for (int i = 0; i < arrLenght - 1; i++) //A minus one is added so that the loops stops before the last element
            {
                for (int j = i + 1; j < arrLenght; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return [nums[i], nums[j]]; //A solution was found
                    }
                }
            }

            return []; //No solution was found
        }

        public static int[] MakeTheSumLinear(int[] nums, int target)
        {
            Dictionary<int, int> storage = [];
            for (int i = 0; i < nums.Length; i++)
            {
                int value = nums[i];
                int complement = target - value;

                if (storage.TryGetValue(complement, out int v))
                {
                    return [i, v];
                }

                storage.TryAdd(nums[i], i);
            }

            return [];
        }
    }
}
