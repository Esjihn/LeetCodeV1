namespace LeetCodeV1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str1 = "()";
            string str2 = "()[]{}";
            string str3 = "(]";
            string str4 = "([)]";

            Console.WriteLine(IsValid(str1));
            Console.WriteLine(IsValid(str2));
            Console.WriteLine(IsValid(str3));
            Console.WriteLine(IsValid(str4));
        }

        /// <summary>
        /// Open brackets must be closed by the same type of brackets.
        /// Open brackets must be closed in the correct order.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsValid(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return false;

            // Brute Force

            // Library 
            Dictionary<int, char> validStrDict = new Dictionary<int, char>();
            
            validStrDict.Add(0, '(');
            validStrDict.Add(1, ')');
            validStrDict.Add(2, '[');
            validStrDict.Add(3, ']');
            validStrDict.Add(4, '{');
            validStrDict.Add(5, '}');

            for (int i = 0; i < s.Length; i++)
            {
                
            }

            return false;
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