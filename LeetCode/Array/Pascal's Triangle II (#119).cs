public class Solution {
    public IList<int> GetRow(int rowIndex) {
            var triangle = new List<IList<int>>();
            var result = new List<int>();
            var firstIndex = new List<int>();
            triangle.Add(firstIndex);
            if(rowIndex == 0)
            {
                result.Add(1);
                return result;
            }

            for(int i=1; i<rowIndex + 1; i++)
            {
                var current = triangle[i-1];
                var prev = new List<int>();
                prev.Add(1);
                for(int j=1; j<i; j++)
                {
                    prev.Add(current[j] + current[j-1]);
                }
                prev.Add(1);
                triangle.Add(prev);
                if(i == rowIndex)
                {
                    foreach(int item in prev)
                    {
                        result.Add(item);
                    }
                    return result;
                }
            }
            return result;
    }
}