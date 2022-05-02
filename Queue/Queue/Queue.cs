namespace Queue;
public class Queue
{
    object[] queue = new object[10];
    public void Enqueue(object obj)
    {
        if(peak > 0)
        {
            for (int i = peak-1; i >= 0; i--)
            {
                queue[i+1] = queue[i];
            }
        }
        
        queue[0] = obj;
        peak++;
        
        //throw new NotImplementedException();
    }

    public void Dequeue()
    {
        queue[peak] = null;
        peak--;

        //throw new NotImplementedException();
    }

    public bool Contains(object obj)
    {
        foreach(object item in queue)
            if(item == obj) return true;
        return false;

        //throw new NotImplementedException();
    }

    public object Peak()
    {
        if(peak == 0)
            return null;
        else
            return queue[peak-1];

        //throw new NotImplementedException();
    }

    public void Clear()
    {
        for(int i = 0; i < peak; i++)
        {
            queue[i] = null;
        }
        peak = 0;
        //throw new NotImplementedException();
    }

    public int peak { get; set; }
}
