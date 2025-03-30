public class Solution {
    public int MissingNumber(int[] nums) {
        Array.Sort(nums); int n = nums.Length;
            int start = 0, end = n - 1;
            while(start <= end)
            {
                int middle = (start + end) / 2;
                if(nums[middle] == middle)
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }
            }
            return start;
    }
}
--------------------------------------------------------------------------
public class Solution {
    public int MissingNumber(int[] nums) {
            int n = nums.Length;
            List<int> arr = new List<int>();
            for(int i=0; i<=n; i++)
            {
                arr.Add(i);
            }

            foreach(int item in arr)
            {
                if(!nums.Contains(item))
                {
                    return(item);
                }
            }
            return -1;
    }
}
--------------------------------------------------------------------------
public class Solution {
    public int MissingNumber(int[] nums) {
            Array.Sort(nums);
            if(nums[0] == 1)
            {
                return nums[0] - 1;
            }
            int n = nums.Length;
            int end = 0;
            while(end < n)
            {
                if(end + 1 < n && nums[end] + 1 == nums[end + 1])
                {
                    end++;
                }
                else
                {
                    return nums[end] + 1;
                }
            }
            return -1;
    }
}
--------------------------------------------------------------------------
public class Solution {
    public int MissingNumber(int[] nums) {
        int XOR = 0;
        int n = nums.Length;
        for(int i=0; i<=n; i++)
        {
            XOR ^= i;
        }
        for(int i=0; i<n; i++)
        {
            XOR ^= nums[i];
        }
        return XOR;
    }
}
--------------------------------------------------------------------------
public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length;
        int resultSum = (n*(n+1))/2;
        foreach(int item in nums)
        {
            resultSum -= item;
        }
        return resultSum;
    }
}