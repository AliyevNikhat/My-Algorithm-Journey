public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        List<int> arr = new List<int>();
        Array.Sort(nums1);
        Array.Sort(nums2);
        int Left = 0, Right = 0;
        while(Left < nums1.Length && Right < nums2.Length)
        {
            if(nums1[Left] == nums2[Right])
            {
                arr.Add(nums1[Left]);
                Left++;
                Right++;
            }
            else if(nums1[Left] > nums2[Right])
            {
                Right++;
            }
            else
            {
                Left++;
            }
        }
        return arr.ToArray();
    }
}
-------------------------------------------------------------
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        List<int> arr = new List<int>();
        Dictionary<int, int> frequency = new Dictionary<int, int>();  
        foreach(int item in nums1)
        {
            if(frequency.ContainsKey(item))
            {
                frequency[item]++;
            }
            else
            {
                frequency[item] = 1;
            }
        }

        foreach(int item in nums2)
        {
            if(frequency.ContainsKey(item) && frequency[item] > 0)
            {
                arr.Add(item);
                frequency[item]--;
            }
        }
        return arr.ToArray();
    }
}