public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        Dictionary<int,int> nextGreaterMap  = new Dictionary<int, int>();
            Stack<int> stack = new Stack<int>();
            for(int i=nums2.Length - 1; i >= 0; --i)
            {
                int current = nums2[i];
                while(stack.Count>0 && stack.Peek() <= current)
                {
                    stack.Pop();
                }
                
                if (stack.Count > 0)
                {
                    nextGreaterMap[current] = stack.Peek();
                }
                else
                {
                    nextGreaterMap[current] = -1;
                }
                stack.Push(current);
            }
            for (int i = 0; i < nums1.Length; i++)
            {
                nums1[i] = nextGreaterMap[nums1[i]];
            }
            return nums1;
    }
}
------------------------------------------------------------------
public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        List<int> result = new List<int>();
        Dictionary<int,int> arr = new Dictionary<int,int>();
        for(int i=0; i<nums2.Length;i++)
        {
            if(!arr.ContainsKey(nums2[i]))
            {
                arr[nums2[i]] = i;
            }
        }
        for(int i=0; i<nums1.Length; i++)
        {
            bool check = false;
            int current = nums1[i];
            for(int j=arr[current]; j<nums2.Length; j++)
            {
                if(current < nums2[j])
                {
                    result.Add(nums2[j]);
                    check = true;
                    break;
                }
            }
            if(check == false)
            {
                result.Add(-1);
            }
        }
        return result.ToArray();
    }
}