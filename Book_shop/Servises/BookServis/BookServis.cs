using Book_shop.Entities.DTOes;
using Book_shop.Models;
using Book_shop.MyPattern;

namespace Book_shop.Servises.BookServis
{
    public class BookServis : IBookServis
    {
        private readonly IRepositoryPattern _repoPattern;

        public BookServis(IRepositoryPattern repoPattern)
        {
            _repoPattern = repoPattern;
        }

        public string Create(BookDTO book)
        {
            return _repoPattern.Create(book);
        }

        public string Delete(int id)
        {
            return _repoPattern.Delete(id);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _repoPattern.GetAllBooks();
        }

        public IEnumerable<Book> GetByAuthor(string author)
        {
            return _repoPattern.GetByAuthor(author);
        }

        public IEnumerable<Book> GetByGenre(string genre)
        {
            return _repoPattern.GetByGenre(genre);
        }

        public IEnumerable<Book> GetById(int id)
        {
            return _repoPattern.GetById(id);
        }

        public IEnumerable<Book> GetByTitle(string title)
        {
            return _repoPattern.GetByTitle(title);
        }

        public string Update(int id, BookDTO new_book)
        {
            return _repoPattern.Update(id, new_book);
        }
    }
}
