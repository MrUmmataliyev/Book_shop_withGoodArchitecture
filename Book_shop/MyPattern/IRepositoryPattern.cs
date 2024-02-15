using Book_shop.Entities.DTOes;
using Book_shop.Models;

namespace Book_shop.MyPattern
{
    public interface IRepositoryPattern
    {
        public string Create(BookDTO book);
        public IEnumerable<Book> GetAllBooks();
        public IEnumerable<Book> GetByAuthor(string author);
        public IEnumerable<Book> GetByTitle(string title);
        public IEnumerable<Book> GetByPublishedYear(string title);
        public string Update(int id, BookDTO new_book);
        public string Delete(int id);

    }
}
