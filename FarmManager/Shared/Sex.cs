using System.ComponentModel.DataAnnotations;

namespace FarmManager.Shared
{
    public class Sex
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
