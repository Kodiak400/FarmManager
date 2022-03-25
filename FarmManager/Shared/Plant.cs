using System.ComponentModel.DataAnnotations;

namespace FarmManager.Shared
{
    public class Plant
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [Display(Name ="Roślina")]
        public string Name { get; set; }

        [Display(Name = "Średni plon")]
        public int AverageCrop { get; set; }
    }
}
