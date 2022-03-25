using System.ComponentModel.DataAnnotations;

namespace FarmManager.Shared
{
    public class CropsCalculatorResult
    {
        [Key]
        public int Id { get; set; }

        public string? ApplicationUserId { get; set; }

        public string Name { get; set; }

        public string CropName { get; set; }

        public double CropWeight { get; set; }

        public double CropValue { get; set; }
    }
}
