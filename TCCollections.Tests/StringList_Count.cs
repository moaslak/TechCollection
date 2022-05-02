using Xunit;
using TCCollections;
namespace TCCollections.Tests;

public class StringList_Count
{
    [Fact]
    public void NewListCountIsZero()
    {
        StringList list = new StringList();
        Assert.Equal(0, list.Count);

    }
    [Fact]
    public void SingleAddIsOne()
    {
        StringList list = new StringList();
        list.Add("A");
        
        Assert.Equal(1, list.Count);
    }
    
    [Fact]
    public void MultipleAddIsTrue()
    {
        StringList list = new StringList();
        for (int i = 0; i < 1000; i++)
        {
            list.Add($"{i}");
        }
        
        Assert.Equal(1000, list.Count);
    }
}