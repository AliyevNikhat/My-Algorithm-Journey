public class NumArray {
    private readonly List<int> arr = new List<int>();
    public NumArray(int[] nums) {
        foreach(int item in nums)
        {
            arr.Add(item);
        }
    }
    
    public int SumRange(int left, int right) {
        int Sum = 0;
        for(int i=left; i <= right; i++)
        {
            Sum+=arr[i];
        }
        return Sum;
    }
}