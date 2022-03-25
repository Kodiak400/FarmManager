using System.ComponentModel.DataAnnotations;

namespace FarmManager.Shared
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        public List<Paragraph>? Paragraphs { get; set; }
    }
}
