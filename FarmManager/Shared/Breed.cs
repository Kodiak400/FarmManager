using System.ComponentModel.DataAnnotations;

namespace FarmManager.Shared
{
    public class Breed
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int SpeciesId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Symbol { get; set; }        
    }
}
