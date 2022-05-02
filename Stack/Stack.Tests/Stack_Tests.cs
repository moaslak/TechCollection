using Xunit;
using TCCollections;
namespace TCCollections.Tests;

public class Stack_Tests
{
    [Fact]
    public void PushAndPopSingleValue()
    {
        TCCollections.Stack stack = new TCCollections.Stack();
        
        stack.Push("Action 1");
        object action1 = stack.Pop();

        Assert.Equal("Action 1", action1);
    }

    [Fact]
    public void PushesAndPops()
    {
        TCCollections.Stack stack = new TCCollections.Stack();
        
        stack.Push("A");
        stack.Push("B");
        stack.Push("C");

        Assert.Equal("C", stack.Pop());
        Assert.Equal("B", stack.Pop());
        Assert.Equal("A", stack.Pop());
    }

    [Fact]
    public void TopDoesNotPop()
    {
        TCCollections.Stack stack = new TCCollections.Stack();
        
        stack.Push("A");
        stack.Push("B");
        stack.Push("C");

        Assert.Equal("C", (string) stack.Top());
        Assert.Equal("C", (string) stack.Pop());
    }

    [Fact]
    public void StackContainsElement()
    {
        TCCollections.Stack stack = new TCCollections.Stack();
        
        stack.Push("A");
        stack.Push("B");
        stack.Push("C");

        Assert.True(stack.Contains("B"));
    }
}