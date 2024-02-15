namespace Book_shop.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public DateOnly Published { get; set; }
        public int Price { get; set;}
    }
}
