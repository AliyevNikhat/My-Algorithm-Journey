public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> arr = new HashSet<int>(nums1);
        List<int> result = new List<int>();
        foreach(int item in nums2)
        {
            if(!result.Contains(item) && arr.Contains(item))
            {
                result.Add(item);
            }
        }
        return result.ToArray();
    }
}
---------------------------------------------------------------------
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        List<int> arr = new List<int>();
        Array.Sort(nums1);
        Array.Sort(nums2);
        int i = 0, j = 0;
        while(i < nums1.Length && j < nums2.Length)
        {
            if(nums1[i] == nums2[j])
            {
                if(!arr.Contains(nums2[j])) {arr.Add(nums2[j]);}
                i++;
                j++;
            }
            else if(nums1[i] > nums2[j])
            {
                j++;
            }
            else
            {
                i++;
            }
        }
        return arr.ToArray();
    }
}
---------------------------------------------------------------------
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        List<int> arr = new List<int>();
        Array.Sort(nums1);
        Array.Sort(nums2);
        for(int i=0; i<nums1.Length; i++)
        {
            if (!arr.Contains(nums1[i]) && BinarySearch(nums1[i], nums2))
            {
                arr.Add(nums1[i]);                    
            }
        }
        return arr.ToArray();
    }
    public bool BinarySearch(int target, int[] arr){
        int left = 0, right = arr.Length - 1;
        while(left <= right)
        {
            int middle = (left + right) / 2;
            if(arr[middle] == target)
            {
                return true;
            }
            if(arr[middle] > target)
            {
                right = middle - 1;
            } 
            else
            {
                left = middle + 1;
            }
        }
        return false;
    }
}
---------------------------------------------------------------------
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        List<int> arr = new List<int>();
        Array.Sort(nums1);
        Array.Sort(nums2);
        nums1 = UniqueElement(nums1); 
        nums2 = UniqueElement(nums2);  
        for(int i=0; i<nums1.Length; i++)
        {
            if (!arr.Contains(nums1[i]) && BinarySearch(nums1[i], nums2))
            {
                arr.Add(nums1[i]);                    
            }
        }
        return arr.ToArray();
    }
    public bool BinarySearch(int target, int[] arr){
        int left = 0, right = arr.Length - 1;
        while(left <= right)
        {
            int middle = (left + right) / 2;
            if(arr[middle] == target)
            {
                return true;
            }
            if(arr[middle] > target)
            {
                right = middle - 1;
            } 
            else
            {
                left = middle + 1;
            }
        }
        return false;
    }
    public int[] UniqueElement(int[] arr)
    {
        List<int> result = new List<int>();
        result.Add(arr[0]);
        for(int i=1; i<arr.Length; i++)
        {
            if(arr[i] != arr[i-1])
            {
                result.Add(arr[i]);
            }
        }
        return result.ToArray();
    }
}