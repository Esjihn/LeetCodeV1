namespace LeetCodeV1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (int item in TwoSum(new int[] { 3, 3 }, 6))
            {
                Console.Write(item + " ");
            }
        }

        /// <summary>
        /// Two Sum
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            // Brute Force
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = 0; j < nums.Length; j++)
            //    {
            //        if (target - nums[j] == nums[i])
            //        {
            //            return new int[]{i, j};
            //        }
            //    }
            //}

            Dictionary<int, int> prevMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];

                if (prevMap.ContainsKey(diff))
                {
                    return new int[] { prevMap[diff], i };
                }

                prevMap[nums[i]] = i;
            }

            return null;
        }
    }
}