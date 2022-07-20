using System.Linq;

public class MinStack
{
    private object[] Arr { get; set; }
    private int Peek { get; set; }
    public MinStack()
    {
        Peek = -1;
        Arr = new object[9999];
    }

    public void Push(int val)
    {
        Arr[++Peek] = val;
    }

    public void Pop()
    {
        Arr[Peek--] = null;
    }

    public int Top()
    {
        return (int)Arr[Peek];
    }

    public int GetMin()
    {
        return (int)Arr.Min();
    }
}
/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */