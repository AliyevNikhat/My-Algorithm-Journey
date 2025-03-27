public class Solution {
    public void MoveZeroes(int[] nums) {
        List<int> arr = new List<int>();
        foreach(int item in nums)
        {
            if(item != 0)
            {
                arr.Add(item);
            }
        }
        for(int i=0; i<nums.Length; i++)
        {
            if(i < arr.Count)
            {
                nums[i] = arr[i];
            }    
            else
            {
                nums[i] = 0;
            }
        }
        
    }
}
---------------------------------------------------------------------
public class Solution {
    public void MoveZeroes(int[] nums) {
        int n = nums.Length;
        int k = 1;
        for(int i=nums.Length - 1; i>=0; i--)
        {
            if(nums[i] == 0)
            {
                Swap(nums, i, n - k);
                k++;
            }
        }
    }
    void Swap(int[] nums, int start, int left)
    {
        for(int i=start; i<left; i++)
		{
			int temp = nums[i];
			nums[i] = nums[i+1];
			nums[i+1] = temp;
		}
    }
}
---------------------------------------------------------------------
public class Solution {
    public void MoveZeroes(int[] nums) {
        int i = 0, j =0;
            while(i < nums.Length - 1 && j < nums.Length - 1)
            {
                while(i < nums.Length && nums[i] != 0)
                {
                    i++;
                    j = i;
                }

                while(j < nums.Length && nums[j] == 0)
                {
                    j++;
                }       

                if (i < nums.Length && j < nums.Length)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;   
                }      
            }        
    }
}