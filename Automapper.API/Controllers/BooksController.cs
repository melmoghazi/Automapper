using Automapper.lib;
using Automapper.lib.DTOs;
using Automapper.lib.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Automapper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMapper _mapper;
        public BooksController(IMapper mapper)
        {
            _mapper = mapper;
        }
        /// <summary>
        /// Get All
        /// </summary>
        /// <returns></returns>
        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAll()
        {
            BookData data = new BookData();
            //var booksDTOs =data.GetList().ToList();
            //var booDto = _mapper.Map(data.books, typeof(List<BookDTO>));
            var booDto = _mapper.Map<List<BookDTO>>(data.books);
            return Ok(booDto);
        }
        /// <summary>
        /// Get By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetById")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            BookData data = new BookData();
            var booDto = _mapper.Map<BookDTO>(data.books.SingleOrDefault(b => b.BookId == id));
            return Ok(booDto);
        }

        /// <summary>
        /// Add book
        /// Example: 
        /// {
        ///     "title": "book 4",
        ///     "summary": "this is book 4",
        ///     "authorName": "author 4",
        ///     "price": 20
        /// }
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [Route("Add")]
        [HttpPost]
        public IActionResult Add(BookDTO dto)
        {
            var book = _mapper.Map<Book>(dto);
            return Ok(book);
        }
    }
}
