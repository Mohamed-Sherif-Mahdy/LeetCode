
public class Solution
{
    public int CalPoints(string[] operations) {
        Stack values=new();
       foreach (var item in operations)
       {
        if(item==\C\){values.Pop();}
        else if(item==\D\){values.Push(Convert.ToInt32(values.Peek())*2);}
        else if(item==\+\){
            int last=Convert.ToInt32(values.Pop());
            int first=Convert.ToInt32(values.Peek());
            values.Push(last);
            values.Push(first+last);
        }
        else values.Push(item);
        
       }
    int sum=0;
     while(values.Count>0){
        
        sum+=Convert.ToInt32(values.Pop());
        
     }
        
        
        
        return sum;
        
     }
}