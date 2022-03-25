using System.ComponentModel.DataAnnotations;

namespace FarmManager.Shared
{
    public class Growth
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name ="Etap wzrostu")]
        public string Name { get; set; }
    }
}