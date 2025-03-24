public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int,int> arr = new Dictionary<int,int>();
        foreach(int item in nums)
        {
            if(arr.ContainsKey(item))
            {
                arr[item]++;
            }
            else
            {
                arr[item] = 1;
            }
        }
        foreach(var item in arr)
        {
            if(item.Value == 1)
            {
                return item.Key;
            }
        }
        return 0;
    }
}
----------------------------------------------------------------------------
public class Solution {
    public int SingleNumber(int[] nums) {
        int count = 0;
        for(int i=0; i<nums.Length; i++)
        {
            count = 0;
            for(int j=0; j<nums.Length; j++)
            {
                if(nums[i] == nums[j])
                {
                    count++;
                }
            }
            if(count == 1)
            {
                return nums[i];
            }
        }
        return 0;
    }
}
----------------------------------------------------------------------------
public class Solution {
    public int SingleNumber(int[] nums) {
        int XOR = 0;
            for(int i=0;i<nums.Length;i++)
            {
                XOR^=nums[i];
            }
            return XOR;
    }
}