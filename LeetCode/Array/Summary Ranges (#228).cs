public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> arr = new List<string>();
        int start = 0, end = 0;
            while(start < nums.Length)
            {
                if(end + 1 < nums.Length && nums[end] + 1 == nums[end + 1])
                {
                    end++;
                }
                else
                {
                    if(start == end)
                    {
                        arr.Add($"{nums[start]}");
                    }
                    else
                    {
                        arr.Add($"{nums[start]}->{nums[end]}");
                    }
                    start = end + 1;
                    end = start;
                }
            }
            return arr;
    }
}