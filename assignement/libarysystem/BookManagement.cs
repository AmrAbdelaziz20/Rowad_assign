namespace libarysystem;

public class Book_Management
{
    // WE CAN'T DO IT ARRAY CUZ WE NEED A SPECIFIC SIZE
    private List<Book> books_lis = new List<Book>();
    public void adding(Book book){
        books_lis.Add(book);
    }
    public void remove(string title){
    for (int i = books_lis.Count - 1; i >= 0; i--)
    {
        if (books_lis[i].Title.Equals(title, StringComparison.OrdinalIgnoreCase))
        {
            books_lis.RemoveAt(i);
        }
    }
    }
    public void display_books()
    {
        foreach (var book in books_lis)
        {
            Console.WriteLine(book);
        }
    }
}
