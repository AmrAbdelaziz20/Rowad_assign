namespace libarysystem;

class Program
{static void Main()
    {
        var librarian = new Librarian(1, "Amr");
        var member = new member(1, "Abotreika");
        var book = new Book("special one book", "jose mouriho", 3);
        var bookManagement = new Book_Management();
        var memberManagement = new MemberMangement();
        var borrowingSystem = new BorrowingSys();
        bookManagement.adding(book);
        bookManagement.display_books();
        memberManagement.registring(member);
        memberManagement.display_members();
        borrowingSystem.BorrowBook(member, book);
        borrowingSystem.ReturnBook(member, book);
        bookManagement.display_books();
    }}
