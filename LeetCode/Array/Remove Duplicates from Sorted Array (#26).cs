public class Solution {
    public int RemoveDuplicates(int[] nums) {
        HashSet<int> arr = new HashSet<int>(nums);
        int i=0;
        foreach(int item in arr)
        {
            nums[i] = item;
            i++;
        } 
        return i;
    }
}
-------------------------------------------------------------------------------
public class Solution {
    public int RemoveDuplicates(int[] nums) {
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
        int i=0;
        foreach(var item in arr)
        {
            nums[i] = item.Key;
            i++;
        }       
        return i; 
    }
}
-------------------------------------------------------------------------------
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int count = 1;
			for(int i=1; i<nums.Length; i++)
			{
				if(nums[i-1] != nums[i])
				{
					nums[count] = nums[i];
					count++;
				}
			}	
            return count;
    }
}