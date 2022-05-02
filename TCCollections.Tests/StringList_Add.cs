using Xunit;
using TCCollections;
namespace TCCollections.Tests;

public class TCStringList_Add
{
    [Fact]
    public void NewListCountIsZero()
    {
        StringList list = new StringList();
        
        Assert.Equal(0,list.Count);

    }
    [Fact]
    public void AddingIncreasesCount()
    {
        StringList list = new StringList();
        Assert.Equal(0,list.Count);

        list.Add("Hello");
        Assert.Equal(1,list.Count);

        list.Add("World");
        Assert.Equal(2,list.Count);
    }

    [Fact]
    public void AddedItemIsContained()
    {
        StringList list = new StringList();

        string text = "Hello";
        list.Add(text);

        bool added = list.Contains(text);
        Assert.True(added);
    }

    [Fact]
    public void AddedValueCannotBeNull()
    {
        StringList list = new StringList();

        list.Add(null);
        Assert.Equal(0,list.Count);
    }
}