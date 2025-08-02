namespace Advanced_CS_Assignment_03;
public class Book
{

    public string ISBN { get; set; }
    public string Title { get; set; }
    public string[] Authors { get; set; }
    public DateTime PublicationDate { get; set; }
    public decimal Price { get; set; }
    public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
    {
        this.ISBN = _ISBN;
        this.Title = _Title;
        this.Authors = _Authors;
        this.PublicationDate = _PublicationDate;
        this.Price = _Price;
    }
    public override string ToString()
    {
        return $"{Title} by {string.Join(", ", Authors)} (ISBN: {ISBN}) - Published on {PublicationDate.ToShortDateString()} - Price: {Price:C}";
    }
}
// user-defined delegate for book operations (2.a)
public delegate string BookDelegate(Book B);
public class BookFunctions
{
    private List<Book> books;
    public BookFunctions(List<Book> books) 
    {
         this.books = books;
    }
    #region 2.b
    public void ProcessBooksDelegate<T>(Func<Book,T> func)
    {
        foreach (var book in books)
        {
            Console.WriteLine(func.Invoke(book));
        }
    }
    #endregion
    #region 2.a,b
    public static string GetTitile(Book B)
    {
        return B.Title;
    }
    public static string GetAuthors(Book B)
    {
        return string.Join(", ", B.Authors);
    }
    public static string GetPrice(Book B)
    {
        return $"{B.Price}";
    }
    #endregion 
}