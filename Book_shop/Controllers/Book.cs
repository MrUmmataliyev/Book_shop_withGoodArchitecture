using Book_shop.Entities.DTOes;
using Book_shop.Models;
using Book_shop.MyPattern;
using Book_shop.Servises.BookServis;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Book_shop.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Book : Controller
    {

        private readonly IBookServis _bookServis;


        public Book( IBookServis bookServis)
        {
       
            _bookServis = bookServis;
        }
        [HttpPost]
        public string AddBook(BookDTO book) 
        { 
            return _bookServis.Create(book);
        }

        [HttpGet]
        public IActionResult GetBookAllBooks()
        {
            
            return Ok(_bookServis.GetAllBooks()); 
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
           
            return Ok(_bookServis.GetById(id));
        }
        [HttpGet]
        public IActionResult GetByTitle(string title)
        {
          
            return Ok(_bookServis.GetByTitle(title));
        }
        [HttpGet]
        public IActionResult GetByAuthor(string author)
        {
            return Ok(_bookServis.GetByAuthor(author));
        }
        [HttpGet]
        public IActionResult GetByGenre(string genre)
        {
            return Ok(_bookServis.GetByGenre(genre));
        }
        [HttpPut]
        public IActionResult Put(int id,BookDTO book) 
        {
            
            return Ok(_bookServis.Update(id, book)); 
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_bookServis.Delete(id));
        }
    }
}
