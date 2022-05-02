using Xunit;
using TCCollections;
namespace TCCollections.Tests;

public class StringList_Get
{
    [Fact]
    public void GetEmptyListIsNull()
    {
        StringList list = new StringList();
        
        Assert.Null(list.Get(0));
    }
    [Fact]
    public void GetFirstElementIsNotNull()
    {
        StringList list = new StringList();
        list.Add("Hello");
        
        Assert.NotNull(list.Get(0));
    }

    [Fact]
    public void GetSecondElementIsCorrect()
    {
        StringList list = new StringList();
        list.Add("Hello");
        list.Add("World");
        
        Assert.Equal("World", list.Get(1));
    }
    [Fact]
    public void GetElementAfterRemove()
    {
        StringList list = new StringList();
        list.Add("Hello");
        list.Add("Evil");
        list.Add("World");

        Assert.NotEqual("World", list.Get(1));
        
        list.Remove("Evil");
        Assert.Equal("Hello", list.Get(0));
        Assert.Equal("World", list.Get(1));
    }
    [Fact]
    public void GetLastElementAfterRemoveIsNull()
    {
        StringList list = new StringList();
        list.Add("Hello");
        list.Add("Evil");
        list.Add("World");
        Assert.NotNull(list.Get(2));        
        list.Remove("World");
        Assert.Null(list.Get(2));
    }
}