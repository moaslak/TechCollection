namespace TCCollections;
public class Dictionary
{
    KeyValuePair[] pairs = new KeyValuePair[10];

    class KeyValuePair
    {
        public string Key {get;set;}
        public object Value {get;set;} = new object();
    }

    public void Add(string key, object value)
    {
        KeyValuePair pair = new KeyValuePair();
        pair.Key = key;
        pair.Value = value;
        pairs[Count] = pair;
        Count++;
    }
    public void Remove(string key)
    {
        if (ContainsKey(key))
        {
            int index = 0;
            for(int i = 0; i < Count; i++)
            {
                if(pairs[i].Key == key)
                {
                    index = i;
                    break;
                }
            }
            for(int j = index; j<Count; j++)
            {
                pairs[j] = pairs[j+1];
            }
            pairs[Count] = null;
            Count--;
        }
    }
    public bool ContainsKey(string key)
    {
        foreach(KeyValuePair pair in pairs)
        {
            if(pair.Key == key)
                return true;
        }
        return false;
    }
    public bool ContainsValue(object value)
    {
        foreach(KeyValuePair pair in pairs)
        {
            if(pair.Value == value)
                return true;
        }
        return false;
    }
    public int Count { get; set; }

}
