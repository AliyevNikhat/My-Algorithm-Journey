public class Solution {
    public int RemoveElement(int[] nums, int val) {
        Dictionary<int,int> arr = new Dictionary<int, int>();
			foreach(int item in nums)
			{
				if (item != val)
				{
					if (arr.ContainsKey(item)) 
					{
						arr[item]++; 
					}
					else
					{
						arr[item] = 1;
					}
				}
			}
			int count = 0;
			foreach(var item in arr)
			{
				for(int i=0; i<item.Value; i++)
				{
					nums[count]= item.Key;
					count++;
				}
			}
            return count;
    }
}
-------------------------------------------------------------------------------------------------
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        List<int> arr = new List<int>();
        int count = 0;
        foreach(int item in nums)
        {
            if(item != val)
            {
                arr.Add(item);
            }
        }
        foreach(int item in arr)
        {
            nums[count] = item;
            count++;
        }
        return count;
    }
}
-------------------------------------------------------------------------------------------------
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int count = 0;
        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i] != val)
            {
                nums[count] = nums[i];
                count++;
            }
        }
        return count;
    }
}