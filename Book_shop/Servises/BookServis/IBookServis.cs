using Book_shop.Entities.DTOes;
using Book_shop.Models;

namespace Book_shop.Servises.BookServis
{
    public interface IBookServis
    {
        public string Create(BookDTO book);
        public IEnumerable<Book> GetAllBooks();
        public IEnumerable<Book> GetByAuthor(string author);
        public IEnumerable<Book> GetByTitle(string title);
        public IEnumerable<Book> GetByGenre(string genre);
        public IEnumerable<Book> GetById(int id);

        public string Update(int id, BookDTO new_book);
        public string Delete(int id);
    }
}
