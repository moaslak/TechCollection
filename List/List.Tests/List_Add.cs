using Xunit;
using TCCollections;
namespace TCCollections.Tests;

public class List_Add
{
    [Fact]
    public void NewListCountIsZero()
    {
        List list = new List();
        
        Assert.Equal(0,list.Count);

    }
    [Fact]
    public void AddingIncreasesCount()
    {
        List list = new List();
        Assert.Equal(0,list.Count);

        list.Add("Hello");
        Assert.Equal(1,list.Count);

        list.Add("World");
        Assert.Equal(2,list.Count);
    }
    [Fact]
    public void AddingNumbersAndStrings()
    {
        List list = new List();
        Assert.Equal(0,list.Count);

        list.Add("Hello");
        Assert.Equal(1,list.Count);

        list.Add(100);
        Assert.Equal(100, list.Get(1));
    }

    [Fact]
    public void AddedItemIsContained()
    {
        List list = new List();

        string text = "Hello";
        list.Add(text);

        bool added = list.Contains(text);
        Assert.True(added);
    }

    [Fact]
    public void AddedValueCannotBeNull()
    {
        List list = new List();

        list.Add(null);
        Assert.Equal(0,list.Count);
    }

}