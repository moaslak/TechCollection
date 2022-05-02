using Xunit;
using TCCollections;
namespace TCCollections.Tests;

public class List_Count
{
    [Fact]
    public void NewListCountIsZero()
    {
        List list = new List();
        Assert.Equal(0, list.Count);

    }
    [Fact]
    public void SingleAddIsOne()
    {
        List list = new List();
        list.Add("A");
        
        Assert.Equal(1, list.Count);
    }
    
    [Fact]
    public void MultipleAddIsTrue()
    {
        List list = new List();
        for (int i = 0; i < 1000; i++)
        {
            list.Add($"{i}");
        }
        
        Assert.Equal(list.Count, 1000);
    }
}