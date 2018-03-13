namespace ArraysQuestions
{
    /*
     * Missing Number
     * 
     * Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.
     * 
     * https://leetcode.com/problems/missing-number/description/
     */
    public class Task19MissingNumber
    {
        public static int Do(int[] nums)
        {
            if (nums.Length == 0) return 0;

            var sum = 0;
            var idealSum = (nums.Length + 1) * (nums.Length) / 2;

            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            return idealSum - sum;
        }
    }
}
