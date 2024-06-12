using System.Collections;

namespace hw_cSH_6;

public class Library: IEnumerable
{
    public string Name { get; set; }
    public string Adress { get; set; }
    private Book[] _books;

    public Library(string name, string adress, Book[] books)
    {
        _books = new Book[books.Length];
        for (int i = 0; i < books.Length; i++)
        {
            _books[i] = new Book(books[i].Name, books[i].Author, books[i].Year, books[i].CountPages);
        }
    }

    public void AddBook(Book book)
    {
        Book[] newArr = new Book[_books.Length + 1];
        for (int i = 0; i < _books.Length; i++)
        {
            newArr[i] = _books[i];
        }

        newArr[_books.Length] = book;
        _books = newArr;
    }
    
    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < _books.Length; i++)
            yield return _books[i]; 
    }
}