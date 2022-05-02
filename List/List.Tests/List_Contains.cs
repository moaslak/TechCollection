using Xunit;
using TCCollections;
namespace TCCollections.Tests;

public class List_Contains
{
    [Fact]
    public void ContainsText_IsTrue()
    {
        List list = new List();
        list.Add("A");
        list.Add("B");
        list.Add("C");
        
        Assert.True(list.Contains("A"));
        Assert.True(list.Contains("B"));
        Assert.True(list.Contains("C"));

    }
    [Fact]
    public void ContainsText_IsFalse()
    {
        List list = new List();
        list.Add("A");
        list.Add("B");
        list.Add("C");
        
        Assert.False(list.Contains(""));
        Assert.False(list.Contains("a"));
        Assert.False(list.Contains("b"));
        Assert.False(list.Contains("c"));
        Assert.False(list.Contains("D"));
        Assert.False(list.Contains(" "));
        Assert.False(list.Contains("AA"));
        Assert.False(list.Contains("ABC"));
        Assert.False(list.Contains("*"));

    }
}