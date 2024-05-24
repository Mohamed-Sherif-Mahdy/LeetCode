public class Solution {
    public bool IsValid(string s) {
        if(s.Length%2==1) 
        return false;
        Stack<char> parentheses=new();
        Dictionary<char,char> dictionary=new() 
        {
         {']','['}
        ,{')','('}
        ,{'}','{'}
        };
        foreach (var item in s)
        {
         if(dictionary.ContainsKey(item) && parentheses.Count>0){
            if(dictionary[item]!=parentheses.Pop())
            return false;
         }
         else parentheses.Push(item);
        }
        if(parentheses.Count>0)
        return false;
        else return true;
    }
}