using System.ComponentModel.DataAnnotations;

namespace MovieOrg.Domain.Entities
{
    public class Link
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Type { get; set; } // "download" or "streaming"
        [Required]
        public string SourceName { get; set; } // e.g. Google Drive
        public string Quality { get; set; } // e.g., "1080p", "720p"
        public string Url { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
