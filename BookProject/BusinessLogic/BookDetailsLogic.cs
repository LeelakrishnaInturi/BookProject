using BookProject.Entities;
using BookProject.IBusinessLogic;
using BookProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.BusinessLogic
{
    public class BookDetailsLogic: IBookDetailsLogic
    {
        BookDetailsRepository bookDetailsRepository = new BookDetailsRepository();
        //This Method is Used to Add Data
        public int AddBookDetails(BookDetail bookDetail)
        {
            return bookDetailsRepository.AddBookDetails(bookDetail);
        }
        //This Method is used to Get The Data
        public List<BookDetail> GetBookDetails()
        {
            return bookDetailsRepository.GetBookDetails();
        }
        //This Method is Used to Get The Data By Id
        public BookDetail GetBookDetailsById(Guid bookId)
        {
            return bookDetailsRepository.GetBookDetailsById(bookId);
        }
    }
}
