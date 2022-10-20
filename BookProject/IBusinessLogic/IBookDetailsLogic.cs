using BookProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.IBusinessLogic
{
    public interface IBookDetailsLogic
    {
        //This Method is used to Add Data
        public int AddBookDetails(BookDetail bookDetail);
        //This Method is Used to Get the data
        public List<BookDetail> GetBookDetails();
        //This Method is used to Get the Data By Id
        public BookDetail GetBookDetailsById(Guid bookId);
    }
}
