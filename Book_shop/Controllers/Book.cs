using Book_shop.Entities.DTOes;
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
    }
}
