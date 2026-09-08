namespace MoviesDirectory.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public decimal BoxOfficeReceipts { get; set; }
        public Director? Director { get; set; }
        public int? DirectorId { get; set; }
    }

    public class Director
    {
        public int DirectorId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Movie>? Movies { get; set; }
    }
}
