
public class Solution 
{
  public int[] TwoSum(int[] nums, int target) 
  {
    int i;
    int y=0;
    for ( i = 0; i < nums.Length; i++)
      {
      int x = target - nums[i];
      y = Array.IndexOf(nums, x);
      if (y!=-1 && y!=i)
        {
          return new[]{i,y};
        }
      }
    return new[]{-1,-1};
  }
}