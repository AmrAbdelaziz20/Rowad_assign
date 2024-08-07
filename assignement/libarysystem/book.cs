using System;
using System.Collections.Generic;

namespace libarysystem;

public class Book
{
public string Title { get; set; }
    public string Author { get; set; }
    public int NumOfCopies { get; set; }

    public Book(string title, string author, int numberOfCopies)
    {
        Title = title;
        Author = author;
        NumOfCopies = numberOfCopies;
    }

    public override string ToString()
    {
        return $"{Title} by {Author}, Copies: {NumOfCopies}";
    }
}
