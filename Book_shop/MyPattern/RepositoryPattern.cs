using Book_shop.Entities.DTOes;
using Book_shop.Models;
using Npgsql;

namespace Book_shop.MyPattern
{
    public class RepositoryPattern : IRepositoryPattern
    {
        public IConfiguration _configuration;

        public RepositoryPattern(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Create(BookDTO book)
        {
            try
            {
                using(NpgsqlConnection  connection = new NpgsqlConnection())
                {

                }
                return "ok";
            }
            catch 
            {

                return "ok";
            }
        }

        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetByAuthor(string author)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetByPublishedYear(string title)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public string Update(int id, BookDTO new_book)
        {
            throw new NotImplementedException();
        }
    }
}
