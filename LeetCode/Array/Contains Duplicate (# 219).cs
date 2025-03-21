public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) 
    {
        Dictionary<int,int> arr = new Dictionary<int, int>();
        for(int i=0; i<nums.Length; i++)
		{
			if(arr.ContainsKey(nums[i]))
			{
				int m = Math.Abs(arr[nums[i]] - i);
				if(m <= k)
				{
					return true;
				}
                		arr[nums[i]] = i;
			}
			if(!arr.ContainsKey(nums[i]))
			{
				arr[nums[i]] = i;
			}
		}			
        return false;
    }
}