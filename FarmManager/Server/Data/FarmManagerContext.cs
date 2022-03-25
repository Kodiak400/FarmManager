using Duende.IdentityServer.EntityFramework.Options;
using FarmManager.Server.Models;
using FarmManager.Shared;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FarmManager.Server.Data
{
    public class FarmManagerContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public FarmManagerContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions) { }        

        public DbSet<Animal> Animals { get; set; }

        public DbSet<Breed> Breeds { get; set; }

        public DbSet<Sex> Sexes { get; set; }

        public DbSet<Species> Species { get; set; }

        public DbSet<TransferReason> TransferReasons { get; set; }

        public DbSet<Field> Fields { get; set; }

        public DbSet<Plantation> Plantations { get; set; }

        public DbSet<Plant> Plants { get; set; }

        public DbSet<Growth> Growths { get; set; }

        public DbSet<Article> Articles { get; set; }

        public DbSet<AnimalsCalculatorResult> AnimalsCalculatorResults { get; set; }

        public DbSet<CropsCalculatorResult> CropsCalculatorResults { get; set; }
    }
}