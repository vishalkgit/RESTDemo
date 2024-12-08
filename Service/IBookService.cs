using RESTDemo.Model;

namespace RESTDemo.Service
{
    public interface IBookService
    {
        IEnumerable<Book> GetBookByAuthor(string name);

        IEnumerable<Book> GetBooks();

        public int AddBook(Book book);

        public int DeleteBook(int id);

        public Book GetBookById(int id);

        public int UpdateBook(Book book);
    }
}
