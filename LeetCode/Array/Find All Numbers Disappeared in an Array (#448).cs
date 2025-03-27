public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
            List<int> arr = new List<int>();
            for(int i=1; i<=nums.Length; i++)
            {
                arr.Add(i);
            }
            List<int> result = new List<int>();
            foreach(int item in arr)
            {
                if(!nums.Contains(item))
                {
                    result.Add(item);
                }
            }
            return result;
    }
}