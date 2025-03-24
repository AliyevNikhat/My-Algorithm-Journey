public class Solution {
    public int MajorityElement(int[] nums) {
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
        int n = nums.Length / 2;
        foreach(var item in arr)
        {
            if(item.Value > n)
            {
                return item.Key;
            }
        }
        return -1;
    }
}