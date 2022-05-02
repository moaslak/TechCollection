using System.Collections;

namespace TCCollections;
public class List : IEnumerable<object>
{
    object[] list = new object[10];

    public void Add(object obj)
    {
        if(obj != null)
        {
            object[] newList = new object[list.Length + 1];
            for (int i = 0; i < list.Length; i++)
            {
                newList[i] = list[i];
            }
            newList[Count] = obj;
            list = newList;
            Count++;
        }
    }
    public void Remove(object obj)
    {
        
        if (Contains(obj))
        {
            int offset = 0;
            for(int i = 0; i < list.Length-1; i++)
            {
                if(list[i] == obj)
                    offset++;
                list[i] = list[i + offset];
            }
            Count--;
        }
        
    }
    public object? Get(int index) 
    {
        object obj = list[index];
        return obj;

    }
    public bool Contains(object obj)
    {
        foreach(object o in list)
        {
            if (o == obj)
                return true;
        }
        return false;
    }
    public int Find(object obj)
    {
        for(int i = 0; i < list.Length; i++)
        {
            if(obj == list[i])
                return i;
        }
        return -1;
    }

    public IEnumerator<object> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public int Count { get; set; }


    static void Main(string[] args)
    {
        List array = new List();
        foreach (int i in array)
        {

        }

    }
}
