public class Solution {
    public int RemoveDuplicates(int[] nums) {
      
        var distinctArray = nums.Distinct().ToArray();
        int k = distinctArray.Length;



        for (int i = 0; i < k; i++) {
            nums[i] = distinctArray[i];
        }

        return k;
    }
}