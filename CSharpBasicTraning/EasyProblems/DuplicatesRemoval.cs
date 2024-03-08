namespace CSharpBasicTraning.EasyProblems
{
    internal class DuplicatesRemoval
    {
        public static int RemoveDuplicates(int[] nums) 
        {
            if (nums.Length == 0) return 0;
            
            int k = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[k])
                {
                    nums[k+1] = nums[i];
                    k++;
                }
            }

            return k+1;
        }

        public static int DuplicatesDeletion(int[] nums, int val) 
        {
            if (nums.Length == 0) return 0;

            int k = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        }
    }
}
