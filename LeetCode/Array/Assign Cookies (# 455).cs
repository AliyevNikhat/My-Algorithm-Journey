public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        if(s.Length == 0)
        {
            return 0;
        }
        Array.Sort(g);
        Array.Sort(s);
        int i=0, j = 0;
        int result = 0;
        while(i < g.Length && j < s.Length)
        {
            if(g[i] == s[j])
            {
                i++;
                j++;
                result++;
            }
            else if(g[i] <= s[j])
            {
                i++;
                j++;
                result++;
            }
            else
            {
                j++;
            }
        }
        return result;
    }
}