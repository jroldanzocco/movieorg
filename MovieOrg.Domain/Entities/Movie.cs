using System.ComponentModel.DataAnnotations;

namespace MovieOrg.Domain.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public int ReleaseYear { get; set; }
        public int Duration { get; set; }
        public string PosterUrl { get; set; }
        public string TrailerUrl { get; set; }

        public ICollection<Genre> Genres { get; set; } = new List<Genre>();
        public ICollection<Link> Links { get; set; } = new List<Link>();
    }
}
