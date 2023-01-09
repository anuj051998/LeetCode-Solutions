public class MyStack
{

    private readonly object[] Queue;
    private int top;
    public MyStack()
    {
        Queue = new object[999];
        top = -1;
    }

    public void Push(int x)
    {
        Queue[++top] = x;
    }

    public int Pop()
    {
        int item = (int)Queue[top];
        Queue[top--] = null;
        return item;

    }

    public int Top()
    {
        return (int)Queue[top];
    }

    public bool Empty()
    {
        return top == -1;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */