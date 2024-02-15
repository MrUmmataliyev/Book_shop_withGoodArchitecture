namespace Book_shop.Entities.DTOes
{
    public class BookDTO
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public DateOnly Published { get; set; }
        public int Price { get; set; }
    }
}
