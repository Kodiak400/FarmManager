using System.ComponentModel.DataAnnotations;

namespace FarmManager.Shared
{
    public class TransferReason
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Direction { get; set; }
    }
}
