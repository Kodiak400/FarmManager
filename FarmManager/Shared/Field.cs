using System.ComponentModel.DataAnnotations;

namespace FarmManager.Shared
{
    public class Field
    {
        private List<Plantation>? plantations;
        private double area;

        [Key]
        public int Id { get; set; }

        public string? ApplicationUserId { get; set; }

        [Required]
        [Display(Name = "Numer działki")]
        public string PlotNumber { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Proszę wprowadzić prawidłową wartość.")]
        [Display(Name = "Powierzchnia")]
        public double Area { get { return area; } set { area = value; } }

        [Display(Name = "Nazwa pola")]
        public string? Name { get; set; }

        [Display(Name = "Lokalizacja")]
        public string? Location { get; set; }

        [Display(Name = "Uprawy")]
        public List<Plantation>? Plantations
        {
            get
            {
                return plantations;
            }
            set
            {
                if (value?.Sum(x => x.Area) > area)
                    throw new ArgumentException("Łączna powierzchnia upraw jest większa od powierzchni pola");
                plantations = value;
            }
        }

        [Display(Name = "Powierzchnia upraw")]
        public double? SowedArea { get { return GetSowedArea(); } }

        private double? GetSowedArea()
        {
            if (Plantations == null)
                return null;
            var sowedArea = plantations.Sum(x => x.Area);

            return sowedArea;
        }
    }
}
