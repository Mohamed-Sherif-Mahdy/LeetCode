public class MinStack {
Stack<int> StackList;
Stack<int> minmum;
    public MinStack() {
        StackList=new Stack<int>();
        minmum=new();
    }
    
    public void Push(int val) {
        if(StackList.Count==0 || val<=minmum.Peek()) {
            minmum.Push(val);
        }

        StackList.Push(val);
    }
    
    public void Pop() {
        if(StackList.Peek()==minmum.Peek()){
            minmum.Pop();
        }

        StackList.Pop();
    }
    
    public int Top() {
        return StackList.Peek();
    }
    
    public int GetMin() {
        return minmum.Peek();
    }
}