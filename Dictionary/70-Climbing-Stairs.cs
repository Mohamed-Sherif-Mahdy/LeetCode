public class Solution {
    Dictionary<int,int> dp=new();
    public int ClimbStairs(int n) {
         
        if(n<=1) return 1;
        if(dp.ContainsKey(n)) return dp[n];
        else
        return dp[n]=ClimbStairs(n-1)+ClimbStairs(n-2);
    }
}