namespace ArraysQuestions
{
    /*
     * Search Insert Position
     * Given a sorted array and a target value, return the index if the target is found. 
     * If not, return the index where it would be if it were inserted in order.
     * 
     * Example 1:
     * Input: [1,3,5,6], 5
     * Output: 2
     * 
     * Example 2:
     * Input: [1,3,5,6], 2
     * Output: 1
     * 
     * Example 3:
     * Input: [1,3,5,6], 7
     * Output: 4
     * 
     * Example 4:
     * Input: [1,3,5,6], 0
     * Output: 0
     * https://leetcode.com/problems/search-insert-position/description/
     */
    public class Task06SearchInsertPosition
    {
        public static int Do(int[] nums, int target)
        {
            if (target < nums[0]) return 0;
            if (target > nums[nums.Length - 1]) return nums.Length;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target) return i;                
            }

            for (var i = 0; i < nums.Length - 1; i++)
            {
                if (target > nums[i] && target < nums[i + 1]) return i + 1;
            }            

            return -1;
        }
    }
}
