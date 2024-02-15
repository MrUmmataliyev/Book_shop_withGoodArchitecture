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
            using (NpgsqlConnection connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "select * from books";
                return connection.Query<Book>(query);
            }
        }




        public IEnumerable<Book> GetByAuthor(string author)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "select * from books where author=@author";
                return connection.Query<Book>(query, new {author=author});
            }
        }

        public IEnumerable<Book> GetByGenre(string genre)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "select * from books where genre=@genre";
                return connection.Query<Book>(query, new { genre=genre });
            }
        }

        public IEnumerable<Book> GetById(int id)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "select * from books where id=@id";
                return connection.Query<Book>(query, new { id = id });
            }
        }

        public IEnumerable<Book> GetByTitle(string title)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "select * from books where title=@title";
                return connection.Query<Book>(query, new { title = title });
            }
        }

        public string Update(int id, BookDTO new_book)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "update books set title=@Title, genre=@Genre, author=@Author, price=@Price";
                BookDTO parametrs = new BookDTO
                {
                    Title = new_book.Title,
                    Genre = new_book.Genre,
                    Author = new_book.Author,

                    Price = new_book.Price
                };
                var status = connection.Execute(query, parametrs);

                return $"Entered data = {status}";
            }
        }
    }
}
