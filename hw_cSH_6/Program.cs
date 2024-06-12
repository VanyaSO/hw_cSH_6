namespace hw_cSH_6;

class Program
{
    static void Main(string[] args)
    {
        Book[] books = new Book[4]; 
        books[0] = new Book("Pride and Prejudice", "Jane Austen", 1813, 432);
        books[1] = new Book("The Catcher in the Rye", "J.D. Salinger", 1951, 214);
        books[2] = new Book("The Hobbit", "J.R.R. Tolkien", 1937, 310);
        books[3] = new Book("Any", "Fyodor Dostoevsky", 1866, 671);

        Library library = new Library("New Library", "Pushkina 16", books);
        library.AddBook(new Book("Test", "Dostoevsky", 1999, 11));
        foreach (Book book in library)
        {
            Console.WriteLine(book);
        }
    }
}