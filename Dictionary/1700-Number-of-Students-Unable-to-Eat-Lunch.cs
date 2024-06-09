public class Solution {
 Dictionary<int,int> dict=new();

    public int CountStudents(int[] students, int[] sandwiches) {
         dict[0]=0;
            dict[1]=0;
  for(int i=0;i<students.Length;i++){
           
            dict[students[i]]++;
           
        }
       foreach(int j in sandwiches){
        if(dict[j]>0) dict[j]--;
        else break;
       }
       return dict[0]+dict[1];


    }
}