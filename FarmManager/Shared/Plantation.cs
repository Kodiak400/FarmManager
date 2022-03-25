using System.ComponentModel.DataAnnotations;

namespace FarmManager.Shared
{
    public class Plantation
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = " Nazwa jest wymagana")]
        [MinLength(3, ErrorMessage = "Nazwa musi posiadać conajmniej 3 znaki")]
        [Display(Name ="Nazwa")]
        public string? Name { get; set; }

        [Required(ErrorMessage = " Pole jest wymagane")]
        public int? FieldId { get; set; }

        [Required(ErrorMessage = " Roślina jest wymagana")]
        public int? PlantId { get; set; }

        [Display(Name="Roślina")]
        public Plant? Plant { get; set; }

        [Required(ErrorMessage = "Powierzchnia jest wymagana")]
        [Display(Name="Powierzchnia")]
        public double? Area { get; set; }
        
        [Required(ErrorMessage = "Data siewu jest wymagana")]
        [Display(Name="Data siewu")]
        [DataType(DataType.Date)]
        public DateTime SowingDate { get; set; }

        [Required(ErrorMessage = "Etap wzrostu jest wymagany")]
        public int? GrowthId { get; set; }

        [Display(Name = "Etap wzrostu")]
        public Growth? Growth { get; set; }

        public bool Harvested { get; set; }

        [Display(Name = "Data zbioru")]
        [DataType(DataType.Date, ErrorMessage = "Data siewu jest wymagana")]
        public DateTime? HarvestingDate { get; set; }        

        [Display(Name="Plon")]
        public double? Croop { get; set; }
    }
}