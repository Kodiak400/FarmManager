using System.ComponentModel.DataAnnotations;

namespace FarmManager.Shared
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        
        public string? ApplicationUserId { get; set; }

        [Required(ErrorMessage = "Numer identyfikacyjny jest wymagany.")]
        [RegularExpression("^PL[0-9]{12}", ErrorMessage = "Numer musi zaczynać się od \"PL\" po którym następuje 12 cyfr.")]
        [StringLength(14, MinimumLength = 14,ErrorMessage ="Wprowadź 14 znakowy numer")]
        public string IdentityNumber { get; set; }

        [Required(ErrorMessage = "Numer identyfikacyjny matki jest wymagany.")]
        [RegularExpression("^PL[0-9]{12}", ErrorMessage = "Numer musi zaczynać się od \"PL\" po którym następuje 12 cyfr.")]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "Wprowadź 14 znakowy numer")]
        public string MotherIdentityNumber { get; set; }

        [Required(ErrorMessage = "Data urodzenia jest wymagana.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? Birthdate { get; set; }

        [Required(ErrorMessage = "Data przybycia jest wymagana.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? IncomeDate { get; set; }

        [Required(ErrorMessage = "Powód przybycia jest wymagany.")]
        public int? IncomeReasonId { get; set; }

        public TransferReason? IncomeReason { get; set; }

        [Required(ErrorMessage = "Gatunek jest wymagany.")]
        public int? SpeciesId { get; set; }

        public Species? Species { get; set; }

        [Required(ErrorMessage = "Rasa jest wymagana.")]
        public int? BreedId { get; set; }

        public Breed? Breed { get; set; }

        [Required(ErrorMessage = "Płeć jest wymagana.")]
        public int? SexId { get; set; }

        public Sex? Sex { get; set; }       

        public DateTime? OutcomeDate { get; set; }

        public TransferReason? OutcomeReason { get; set; }

        public int? OutcomeReasonId { get; set; }

        public string? Name { get; set; }        
    }
}
