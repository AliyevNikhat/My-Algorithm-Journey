public class Solution {
    public IList<IList<int>> Generate(int numRows) {
            List<IList<int>> arr = new List<IList<int>>();
            if(numRows == 0) { return arr;}
            List<int> FirstElement = new List<int>();
            FirstElement.Add(1);
            arr.Add(FirstElement);

            for(int i=1; i<numRows; i++)
            {
                var current = arr[i-1];
                var temp = new List<int>();
                temp.Add(1);
                for(int j=1; j<i; j++)
                {
                    temp.Add(current[j] + current[j-1]); 
                }
                temp.Add(1);
                arr.Add(temp);
            }
            return arr;
    }
}