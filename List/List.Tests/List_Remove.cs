using Xunit;
using TCCollections;
namespace TCCollections.Tests;

public class List_Remove
{
    [Fact]
    public void RemoveOnEmptyListDoesNotThrowException()
    {
        List list = new List();
        
        list.Remove("Aint there");
    }
    [Fact]
    public void RemoveSingleElement_CountIs0()
    {
        List list = new List();
        list.Add("Hello");

        list.Remove("Hello");
        
        Assert.Equal(0, list.Count);
    }

    [Fact]
    public void RemoveOrderIsCorrect()
    {
        List list = new List();
        list.Add("Hello");
        list.Add("Beautiful");
        list.Add("World");
        
        list.Remove(
            list.Get( 
                list.Find("Hello")
            )
        );
        Assert.Equal(2,list.Count);
        Assert.Equal("Beautiful", list.Get( 0 ));

        list.Remove(
            list.Get( 
                list.Find("Beautiful")
            )
        );
        Assert.Equal(1,list.Count);
        Assert.Equal("World", list.Get( 0 ));


        list.Remove(
            list.Get( 
                list.Find("World")
            )
        );
        Assert.Equal(0,list.Count);
        Assert.Null(list.Get( 0 ));
    }
    [Fact]
    public void GetElementAfterRemove()
    {
        List list = new List();
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
        List list = new List();
        list.Add("Hello");
        list.Add("Evil");
        list.Add("World");
        Assert.NotNull(list.Get(2));        
        list.Remove("World");
        Assert.Null(list.Get(2));
    }
}