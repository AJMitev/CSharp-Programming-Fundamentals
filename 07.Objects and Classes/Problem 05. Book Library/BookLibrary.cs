using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

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
public class BookLibrary
{
    public static void Main()
    {
        int booksCounter = int.Parse(Console.ReadLine());

        var library = new Library("New Library");

        for (int i = 0; i < booksCounter; i++)
        {
            string[] currentBookData = Console.ReadLine().Split().ToArray();

            Book currentBook = GetCurrentBook(currentBookData);

            library.Books.Add(currentBook);
        }

        Dictionary<string, List<Book>> booksByAuthor = CreateBooksByAuthor(library);

        foreach (var authorEntry in booksByAuthor.OrderByDescending(a => a.Value.Select(b => b.Price).Sum()).ThenBy(a => a.Key))
        {
            string author = authorEntry.Key;
            decimal totalPrice = authorEntry.Value.Select(x => x.Price).Sum();
            Console.WriteLine($"{author} -> {totalPrice:f2}");
        }

    }

    private static Dictionary<string, List<Book>> CreateBooksByAuthor(Library library)
    {
        var booksByAuthor = new Dictionary<string, List<Book>>();
        foreach (var book in library.Books)
        {
            string author = book.Author;
            if (!booksByAuthor.ContainsKey(author))
            {
                booksByAuthor.Add(author, new List<Book>());
            }
            booksByAuthor[author].Add(book);
        }

        return booksByAuthor;
    }

    private static Book GetCurrentBook(string[] currentBookData)
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