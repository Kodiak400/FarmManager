using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FarmManager.Shared
{
    public class Species
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public ICollection<Breed> Breeds { get; set; }
    }
}
