namespace libarysystem;

public class BorrowedBookRecord
{
    public member Member { get; set; }
    public Book Book { get; set; }

    public BorrowedBookRecord(member member, Book book)
    {
        Member = member;
        Book = book;
    }
}