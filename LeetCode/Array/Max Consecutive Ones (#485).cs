public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
            int maxCount = 0, currentCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    currentCount++;
                    maxCount = Math.Max(maxCount, currentCount);
                }
                else
                {
                    currentCount = 0;
                }
            }
            return maxCount;
    }
}