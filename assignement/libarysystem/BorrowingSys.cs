namespace libarysystem;

public class BorrowingSys
{
    private List<BorrowedBookRecord> borrowedBooks = new List<BorrowedBookRecord>();

    public void BorrowBook(member member, Book book)
    {
        if (book.NumOfCopies > 0)
        {
            borrowedBooks.Add(new BorrowedBookRecord(member, book));
            book.NumOfCopies--;
            Console.WriteLine($"{member.Name} borrowed {book.Title}");
        }
        else
        {
            Console.WriteLine($"No copies available for {book.Title}");
        }
    }

    public void ReturnBook(member member, Book book)
    {
        var recordToRemove = borrowedBooks.Find(record => record.Member.Equals(member) && record.Book.Equals(book));
        
        if (recordToRemove != null)
        {
            borrowedBooks.Remove(recordToRemove);
            book.NumOfCopies++;
            Console.WriteLine($"{member.Name} returned {book.Title}");
        }
        else
        {
            Console.WriteLine($"{member.Name} did not borrow {book.Title}");
        }
    }
}
