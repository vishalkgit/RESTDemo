using RESTDemo.Data;
using RESTDemo.Model;

namespace RESTDemo.Repositories
{
    public class BookRepository:IBookRepository
    {
        private readonly ApplicationDbContext db;

        public BookRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public int AddBook(Book book)
        {
            
            int result = 0;
            db.Books?.Add(book);
            result=db.SaveChanges();
            return result;
        }

        public int DeleteBook(int id)
        {
            int result=0;
            var b = db.Books?.Where(x => x.BookId == id).FirstOrDefault();
            if (b!=null)
            {
                db.Books?.Remove(b);   
                result=db.SaveChanges();    

            }
            return result;
            
        }

       

        public IEnumerable<Book> GetBookByAuthor(string name)
        {
           var model=db.Books?.Where(x=>x.BookAuthor.Contains(name)).ToList();
            return model;
        }

        public Book GetBookById(int id)
        {
           return db.Books?.Where(x => x.BookId == id).FirstOrDefault();
        }

        public IEnumerable<Book> GetBooks()
        {
            return db.Books.ToList();   
        }

        //public IEnumerable<Book> GetBooks()
        //{
        //    throw new NotImplementedException();
        //}

        public int UpdateBook(Book book)
        {
            int result = 0;
            var res=db.Books?.Where(x=>x.BookId
            == book.BookId).FirstOrDefault();

            if (res != null) {
               // db.Entry(book).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                res.BookName=book.BookName;
                res.BookAuthor=book.BookAuthor;
                res.BookPrice=book.BookPrice;
                result=db.SaveChanges();    
                    }
            return result;
        }

       
    }
}
