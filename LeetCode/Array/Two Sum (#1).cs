public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> arr = new Dictionary<int, int>();
			
			List<int> result = new List<int>();

			for(int i=0; i<nums.Length; i++)
			{
				int current = target - nums[i];
				if(arr.ContainsKey(current))
				{
					result.Add(arr[current]);
					result.Add(i);
				}
				
				if(!arr.ContainsKey(current))
				{
					arr[nums[i]] = i;
				}
			}
            return result.ToArray();
    }
}

------------------------------------------------------------------------------------------------------------
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        List<int> arr = new List<int>();
        for(int i=0; i<nums.Length; i++)
        {
            for(int j=i+1; j<nums.Length; j++)
            {
                if(nums[i] + nums[j] == target)
                {
                    arr.Add(i);
                    arr.Add(j);
                }
            }
        }
        return arr.ToArray();
    }
}
------------------------------------------------------------------------------------------------------------
