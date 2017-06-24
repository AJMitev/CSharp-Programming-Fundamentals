using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string ISBN { get; set; }
    public decimal Price { get; set; }
}
public class Library
{
    public Library(string name)
    {
        this.Name = name;
        this.Books = new List<Book>();
    }
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}
public class ModerateBookLibrary
{
    public static void Main()
    {
        int booksCounter = int.Parse(Console.ReadLine());

        var library = new Library("New Library");

        for (int i = 0; i < booksCounter; i++)
        {
            string[] currentBookData = Console.ReadLine().Split().ToArray();

            Book currentBook = GetCurrentBookData(currentBookData);

            library.Books.Add(currentBook);
        }

        DateTime releaseDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
        Dictionary<string, DateTime> booksByDate = CreateBooksByDate(library);

        foreach (var book in booksByDate.Where(b=> b.Value>releaseDate).OrderBy(d=>d.Value).ThenBy(n=>n.Key))
        {
            Console.WriteLine($"{book.Key} -> {book.Value:dd.MM.yyyy}");
        }
    }

    private static Dictionary<string, DateTime> CreateBooksByDate(Library library)
    {
        var booksByDate = new Dictionary<string, DateTime>();
        foreach (var book in library.Books)
        {
            string title = book.Title;
            DateTime releaseDate = book.ReleaseDate;

            booksByDate[title] = releaseDate;
        }

        return booksByDate;
    }

    private static Book GetCurrentBookData(string[] currentBookData)
    {
        return new Book()
        {
            Title = currentBookData[0],
            Author = currentBookData[1],
            Publisher = currentBookData[2],
            ISBN = currentBookData[4],
            ReleaseDate = DateTime.ParseExact(currentBookData[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
            Price = decimal.Parse(currentBookData[5])
        };
    }
}
