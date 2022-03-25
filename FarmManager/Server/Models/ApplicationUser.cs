using FarmManager.Shared;
using Microsoft.AspNetCore.Identity;

namespace FarmManager.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Animal> Animals { get; set; }

        public ICollection<Field> Fields { get; set; }
    }
}