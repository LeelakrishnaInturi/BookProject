using BookProject.Entities;
using BookProject.IBusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookDetailsController : ControllerBase
    {
        IBookDetailsLogic _bookDetailsLogic;
        public BookDetailsController(IBookDetailsLogic bookDetailsLogic)
        {
            _bookDetailsLogic = bookDetailsLogic;
        }
        //it is Used to Add the data
        [Route("api/AddBookDetails")]
        [HttpPost]
        public int AddBookDetails(BookDetail bookDetail)
        {
            return _bookDetailsLogic.AddBookDetails(bookDetail);
        }
        //it is Used to Get the Data
        [Route("api/GetBookDetails")]
        [HttpGet]

        public List<BookDetail> GetBookDetails()
        {
            return _bookDetailsLogic.GetBookDetails();
        }
        //it is Used to getv the data By Id
        [Route("api/GetBookDetailsById/{bookId}")]
        [HttpGet]
        public BookDetail GetBookDetailsById(Guid bookId)
        {
            return _bookDetailsLogic.GetBookDetailsById(bookId);
            
        }
    }
}
