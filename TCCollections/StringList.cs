namespace TCCollections;
public class StringList
{
    string[] list = new string[1];
    public void Add(string txt)
    {
        if (txt != null)
        {
            string[] bufferList = list;
            string[] newList = new string[Count + 1];
            list = newList;
            for(int i = 0; i < bufferList.Length; i++)
                list[i] = bufferList[i];
            list[Count] = txt;
            Count++;
        }
    }
    public void Remove(string txt)
    {
        if (Contains(txt))
        {
            int index = 0;
            for(int i = 0; i < list.Length; i++)
            {
                if (list[i] == txt)
                {
                    index = i;
                    break;
                }    
            }
            string[] newList = new string[list.Length];
            int offset = 0;
            for(int i = 0; i < newList.Length; i++)
            {
                if( i == index)
                {
                    list[i] = newList[i+1];
                }
                newList[i] = list[i];    
            }
            for(int i = 0; i < list.Length; i++)
            {
                if (newList[i] == null)
                {
                    newList[i] = newList[i+1];
                }
            }
            list = newList;
        }
    }
    public string? Get(int index) 
    {
        return list[index];
    }
    public bool Contains(string txt)
    {
        foreach(string str in list)
        {
            if(str == txt)
                return true;
        }
        return false;
    }
    public int Find(string txt)
    {
        for(int i = 0; i < list.Length; i++)
        {
            if(list[i] == txt)
                return i;
        }
        return-1;
    }
    public int Count { get; set; } 

}
