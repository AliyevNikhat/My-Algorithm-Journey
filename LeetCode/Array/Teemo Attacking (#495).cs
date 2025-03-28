public class Solution {
    public int FindPoisonedDuration(int[] timeSeries, int duration) {
        if (timeSeries.Length == 0) return 0;
        int totalDuration = 0; 
        for (int i = 1; i < timeSeries.Length; i++)
        {
            int diff = timeSeries[i] - timeSeries[i - 1]; 
            totalDuration += Math.Min(diff, duration);
        }

        return totalDuration + duration;
    }
}
