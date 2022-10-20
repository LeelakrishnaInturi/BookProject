using BookProject.Entities;
using BookProject.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Repository
{
    public class BookDetailsRepository : IBookDetailsRepository
    {
        BooksContext booksContext = new BooksContext();
        int id;
        //This method is used to Add the Data
        public int AddBookDetails(BookDetail bookDetail)
        {
                    
                
                booksContext.BookDetails.Add(bookDetail);
                booksContext.SaveChanges();
            
            return 1;
        }
        //This Method is used to Get the Data
        public List<BookDetail> GetBookDetails()
        {
            var data = booksContext.BookDetails.ToList();
            booksContext.SaveChanges();
            return data;
        }
        //this Method is used to Get Data By Id
        public BookDetail GetBookDetailsById(Guid bookId)
        {
            var data = booksContext.BookDetails.Where(a => a.BookId == bookId).FirstOrDefault();
            booksContext.SaveChanges();
            return data;
        }
    }
}
