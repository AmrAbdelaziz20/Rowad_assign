namespace Advanced_csharp_assing;

public class Stack<T> : IStack<T>
{
    private T[] elements;
    private int size;

    public Stack(int capacity)
    {
        elements = new T[capacity];
        size = 0;
    }

    public void Push(T item)
    {
        if (size == elements.Length)
        {
            throw new StackOverflowException("Stack is full.");
        }
        elements[size++] = item;
    }

    public T Pop()
    {
        if (size == 0)
        {
            throw new StackUnderflowException("Stack is empty.");
        }
        return elements[--size];
    }
}

public class StackOverflowException : Exception
{
    public StackOverflowException(string message) : base(message) { }
}

public class StackUnderflowException : Exception
{
    public StackUnderflowException(string message) : base(message) { }
}
