using System.ComponentModel.DataAnnotations;

namespace MovieOrg.Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Duration { get; set; }
        public string Director { get; set; }
        public string FrontPage { get; set; }
    }
}
