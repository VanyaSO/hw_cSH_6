namespace hw_cSH_6;

public class Book
{
    public string Name { get; set; }
    public string Author { get; set; }
    public uint Year { get; set; }
    public uint CountPages { get; set; }
    public static bool SortByAZ { get; set; }

    static Book()
    {
        SortByAZ = true;
    }
    
    public Book(){}

    public Book(string name, string author, uint year, uint countPages)
    {
        Name = name;
        Author = author;
        Year = year;
        CountPages = countPages;
    }

    public override string ToString()
    {
        return $"{Name}, {Author}, {Year}, {CountPages} pages";
    }
}