namespace bogus_API.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Director { get; set; }
        public List<Order>? Orders { get; set; }
    }
}
