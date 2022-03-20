using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BackEnd.Models;
using BackEnd.Services;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookServices _bookServices;
        public BookController(IBookServices bookServices)
        {
            _bookServices = bookServices;
        }
        [HttpGet("getAll")]
        public List<Book> GetBooks(){
            return _bookServices.GetBooks();
        }
        [HttpGet("getAll/{bookId}")]
        public List<Book> GetBook(){
            return _bookServices.GetBooks();
        }
        [HttpPost("create")]
        public HttpStatusCode AddBook(Book book){
            _bookServices.AddBook(book);
            return HttpStatusCode.OK;
        }
        [HttpPut("update")]
        public HttpStatusCode UpdateBook(Book book){
            _bookServices.UpdateBook(book);
            return HttpStatusCode.OK;
        }
        [HttpDelete("delete")]
        public HttpStatusCode DeleteBook(int id){
            _bookServices.DeleteBook(id);
            return HttpStatusCode.OK;
        }

    }
}