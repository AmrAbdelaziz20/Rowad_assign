namespace Advanced_csharp_assing;

public class GList<T>
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
        Console.WriteLine($"Added: {item}");
    }
}
