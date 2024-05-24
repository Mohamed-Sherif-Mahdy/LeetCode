public class Solution {
    public bool IsPalindrome(int x) {
           if (x < 0) return false;
  var s = x.ToString();
  if (s.Length == 0) return true;
  for (var i = 0; i < s.Length / 2 + 1; i++)
    if (s[i] != s[s.Length - i - 1])
      return false;

  return true;
    }
}