using Book_shop.Entities.DTOes;
using Book_shop.Models;
using Book_shop.MyPattern;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Book_shop.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Book : ControllerBase
    {
        private readonly IRepositoryPattern _bookPattern;


        public Book(IRepositoryPattern bookRepositoryPattern)
        {
            _bookPattern = bookRepositoryPattern;
        }
        [HttpPost]
        public string AddBook(BookDTO book) 
        { 
            return _bookPattern.Create(book);
        }

        [HttpGet]
        public IActionResult GetBookAllBooks()
        {
            
            return Ok(_bookPattern.GetAllBooks()); 
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var res = _bookPattern.GetById(id);
            return Ok(res);
        }
        [HttpGet]
        public IActionResult GetByTitle(string title)
        {
            var res = _bookPattern.GetByTitle(title);
            return Ok(res);
        }
        [HttpGet]
        public IActionResult GetByAuthor(string author)
        {
            var res = _bookPattern.GetByAuthor(author);
            return Ok(res);
        }
        [HttpGet]
        public IActionResult GetByGenre(string genre)
        {
            var res = _bookPattern.GetByGenre(genre);
            return Ok(res);
        }
        [HttpPut]
        public IActionResult Put(int id,BookDTO book) 
        {
            var res = _bookPattern.Update(id,book);
            return Ok(res); 
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var res = _bookPattern.Delete(id);
            return Ok(res);
        }
    }
}
