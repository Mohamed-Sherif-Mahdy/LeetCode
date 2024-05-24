public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> hash = new HashSet<int>();
        foreach(int i in nums){
          if(hash.Contains(i))
          return true;
          else{
                hash.Add(i);
          }
          
        }
        return false;
    }
}