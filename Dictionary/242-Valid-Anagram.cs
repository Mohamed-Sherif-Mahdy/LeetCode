public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> dict=new();
        
        foreach (var item in s)
        {
            if(dict.ContainsKey(item)) dict[item]++;
            else dict.Add(item,1);
            
        }
        if(t.Length!=s.Length) return false;
        foreach (var item in t)
        {
            if(dict.ContainsKey(item)){
                dict[item]--;
                if(dict[item]<0) return false;
                
            }
            else return false;
            
        }
        return true;
    }
}