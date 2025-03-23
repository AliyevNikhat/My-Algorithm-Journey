public class Solution {
    public int[] PlusOne(int[] digits) {
            int end = digits.Length-1;
            if(digits[end] !=9)
            {
                digits[end]++;
                return digits;
            }
            else
            {
                List<int> arr = new List<int>(); 
                while(end >= 0 && digits[end] == 9)
                {
                    digits[end] = 0;
                    end--;
                }
                if(end < 0)
                {
                    arr.Add(1);
                    foreach(int item in digits)
                    {
                        arr.Add(item);
                    }
                    return arr.ToArray();
                }
                else
                {
                    digits[end]++;
                    return digits;
                }
            }
    }
}