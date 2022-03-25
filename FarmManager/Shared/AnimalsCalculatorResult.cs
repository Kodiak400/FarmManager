using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManager.Shared
{
    public class AnimalsCalculatorResult
    {
        [Key]
        public int Id { get; set; }

        public string? ApplicationUserId { get; set; }

        public string Name { get; set; }

        public string ResultDate { get; set; }

        public string SpeciesName { get; set; }
    }
}
