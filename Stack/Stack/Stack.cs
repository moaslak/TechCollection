namespace TCCollections;
public class Stack
{
    object[] list = new object[10];
    int top = 0;
    public void Push(object obj)
    {
        list[top] = obj;
        top++;
        Count++;
        return;
    }
    public object Pop()
    {
        top--;
        Count--;
        return list[top];
    }
    public object Top()
    {
        return list[top-1];
    }
    public bool Contains(object obj)
    {
        foreach(object item in list)
        {
            if(item == obj)
                return true;
        }
        return false;

    }
    public int Count { get; set; }

}
