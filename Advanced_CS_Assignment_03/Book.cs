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
        throw new NotImplementedException();
    }
    public override string ToString()
    {
        throw new NotImplementedException();
    }
}
public class BookFunctions
{
    public static string GetTitile(Book B)
    {
        throw new NotImplementedException();
    }
    public static string GetAuthors(Book B)
    {
        throw new NotImplementedException();
    }
    public static string GetPrice(Book B)
    {
        throw new NotImplementedException();
    }
}