namespace Advanced_CS_Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Create a list of books
            List<Book> books = new List<Book>
            {
                new Book("978-3-16-148410-0", "C# Programming", new string[] { "John Doe", "Jane Smith" }, new DateTime(2020, 1, 15), 29.99m),
                new Book("978-1-23-456789-7", "Advanced C#", new string[] { "Alice Johnson" }, new DateTime(2021, 5, 20), 39.99m),
                new Book("978-0-12-345678-9", "Data Structures and Algorithms", new string[] { "Bob Brown", "Charlie White" }, new DateTime(2019, 8, 10), 49.99m)
            };
            #region 2.a
            //BookFunctions bookFunctions = new BookFunctions(books);
            //Console.WriteLine("Prices : ");
            //bookFunctions.ProcessBooksDelegate(BookFunctions.GetPrice);
            //Console.WriteLine("Titles : ");
            //bookFunctions.ProcessBooksDelegate(BookFunctions.GetTitile);
            //Console.WriteLine("Authors : ");
            //bookFunctions.ProcessBooksDelegate(BookFunctions.GetAuthors);
            #endregion
            #region 2.b
            //BookFunctions bookFunctions = new BookFunctions(books);
            //Console.WriteLine("Prices : ");
            //bookFunctions.ProcessBooksDelegate(BookFunctions.GetPrice);
            //Console.WriteLine("Titles : ");
            //bookFunctions.ProcessBooksDelegate(BookFunctions.GetTitile);
            //Console.WriteLine("Authors : ");
            //bookFunctions.ProcessBooksDelegate(BookFunctions.GetAuthors);
            #endregion
            #region 2.c
            Console.WriteLine("GetISBNs : ");
            BookFunctions bookFunctions = new BookFunctions(books);
            bookFunctions.ProcessBooksDelegate(delegate (Book ISBN) { return ISBN.ISBN; } );
            #endregion
            Console.ReadKey();
        }
    }
}
