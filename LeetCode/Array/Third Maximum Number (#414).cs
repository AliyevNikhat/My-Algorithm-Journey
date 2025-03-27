public class Solution {
    public int ThirdMax(int[] nums) {
        nums = UniqueArray(nums);
        int maxA = int.MinValue;
        int maxB = int.MinValue;
        int maxC = int.MinValue;
        bool checkA = false;
        bool checkB = false;
        bool checkC = false;

        int i=0;
        while(i<nums.Length)
        {
            if(maxA < nums[i])
            {
                maxC = maxB;
                maxB = maxA;
                maxA = nums[i];
                checkA = true;
            }
            else if(maxB < nums[i])
            {
                maxC = maxB;
                maxB = nums[i];
                checkB = true;
            }
            else if (maxC < nums[i])
            {
                maxC = nums[i];
                checkC = true;
            }
            i++;
        }
        if(nums.Length <= 2)
        {
            return maxA;
        }
        else
        {
            return maxC;
        }
    }
    public int[] UniqueArray(int[] arr)
    {
        List<int> result = new List<int>();
        foreach(int item in arr)
        {
            if(!result.Contains(item))
            {
                result.Add(item);
            }
        }
        return result.ToArray();
    }
}