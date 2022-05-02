using Xunit;
namespace Queue.Tests;

public class UnitTest1
{
    Queue CustomQueue = new Queue();
    [Fact]
    public void Enqueue()
    {
        Assert.Equal(0, CustomQueue.peak);
        Assert.False(CustomQueue.Contains("Hello"));
        CustomQueue.Enqueue("Hello");
        Assert.Equal("Hello", CustomQueue.Peak().ToString());
        Assert.Equal(1, CustomQueue.peak);
        Assert.True(CustomQueue.Contains("Hello"));
        CustomQueue.Enqueue("Evil");
        Assert.True(CustomQueue.Contains("Hello"));
        Assert.True(CustomQueue.Contains("Evil"));
        Assert.Equal(2, CustomQueue.peak);
        CustomQueue.Enqueue("World");
        Assert.True(CustomQueue.Contains("Hello"));
        Assert.True(CustomQueue.Contains("Evil"));
        Assert.True(CustomQueue.Contains("World"));
        Assert.Equal(3, CustomQueue.peak);
        Assert.Equal("Hello", CustomQueue.Peak().ToString());
    }

    [Fact]
    public void Dequeue()
    {
        CustomQueue.Enqueue("Hello");
        Assert.Equal("Hello", CustomQueue.Peak().ToString());
        CustomQueue.Enqueue("Evil");
        Assert.Equal("Hello", CustomQueue.Peak().ToString());
        CustomQueue.Enqueue("World");
        Assert.True(CustomQueue.Contains("Hello"));
        Assert.True(CustomQueue.Contains("Evil"));
        Assert.True(CustomQueue.Contains("World"));
        Assert.Equal(3, CustomQueue.peak);
        CustomQueue.Dequeue();
        Assert.Equal("Evil", CustomQueue.Peak().ToString());
        Assert.True(CustomQueue.Contains("Evil"));
        Assert.True(CustomQueue.Contains("World"));
        Assert.Equal(2, CustomQueue.peak);
        CustomQueue.Dequeue();
        Assert.Equal(1, CustomQueue.peak);
        Assert.Equal("World", CustomQueue.Peak().ToString());
        Assert.True(CustomQueue.Contains("World"));
        CustomQueue.Dequeue();
        Assert.Equal(0, CustomQueue.peak);
    }

    [Fact]
    public void Contains()
    {
        Assert.False(CustomQueue.Contains("Hello"));
        Assert.False(CustomQueue.Contains("Evil"));
        Assert.False(CustomQueue.Contains("World"));
        CustomQueue.Enqueue("Hello");
        Assert.Equal("Hello", CustomQueue.Peak().ToString());
        Assert.True(CustomQueue.Contains("Hello"));
        CustomQueue.Enqueue("Evil");
        Assert.Equal("Hello", CustomQueue.Peak().ToString());
        Assert.True(CustomQueue.Contains("Evil"));
        CustomQueue.Enqueue("World");
        Assert.Equal("Hello", CustomQueue.Peak().ToString());
        Assert.True(CustomQueue.Contains("World"));
    }

    [Fact]
    public void Peak()
    {
        Assert.Null(CustomQueue.Peak());
        CustomQueue.Enqueue("Hello");
        Assert.Equal("Hello", CustomQueue.Peak());
        CustomQueue.Enqueue("Evil");
        CustomQueue.Enqueue("World");
        Assert.Equal("Hello", CustomQueue.Peak());

        CustomQueue.Dequeue();
        Assert.Equal("Evil", CustomQueue.Peak());
        CustomQueue.Dequeue();
        Assert.Equal("World", CustomQueue.Peak());
    }

    [Fact]
    public void Clear()
    {
        CustomQueue.Enqueue("Hello");
        Assert.True(CustomQueue.Contains("Hello"));
        CustomQueue.Enqueue("Evil");
        Assert.True(CustomQueue.Contains("Evil"));
        Assert.False(CustomQueue.Contains("World"));
        CustomQueue.Enqueue("World");
        Assert.Equal(3, CustomQueue.peak);
        Assert.Equal("Hello", CustomQueue.Peak());
        CustomQueue.Clear();
        Assert.Equal(0, CustomQueue.peak);
    }
}