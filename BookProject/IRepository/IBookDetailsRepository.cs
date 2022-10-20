using BookProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.IRepository
{
    public interface IBookDetailsRepository
    {
        //This  Method is Used to Add the Data
        public int AddBookDetails(BookDetail bookDetail);
        //This Method is Used to Get The Data
        public List<BookDetail> GetBookDetails();
        //This Method is Used to Get The Data By Id
        public BookDetail GetBookDetailsById(Guid bookId);
    }
}
