using Book_shop.Entities.DTOes;
using Book_shop.Models;
using Dapper;
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
                using (NpgsqlConnection connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    string query = "insert into books(title, genre, author, price) values (@Title, @Genre, @Author, @Price)";
                    BookDTO parametrs = new BookDTO
                    {
                        Title = book.Title,
                        Genre = book.Genre,
                        Author = book.Author,
                    
                        Price = book.Price
                    };
                   var status = connection.Execute(query, parametrs);

                    return $"Entered data = {status}";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

               
           
        }

        public string Delete(int id)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    string query = "delete from books where id = @id";


                    var status = connection.Execute(query, new {id=id});

                    return $"Deleted data = {status}";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
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
