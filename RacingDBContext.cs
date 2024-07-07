
using Microsoft.EntityFrameworkCore;
using RacingEntities.Entities;
using RacingEntities.Entities.MemberInfoEntities;
using RacingEntities.Entities.RaceEntities;
using RacingEntities.Entities.Vehicle;
using RacingEntities.Entities.VehicleInfoEntity;

namespace RacingPractice
{
    public class RacingDBContext:DbContext
    {
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentType> DocumentsType { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Photo> Photos { get; set; }


        public DbSet<Citizenship> Citizenships { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Flat> Flats { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Street> Streets { get; set; }


        public DbSet<RaceClass> RaceClasses { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Team> Teams { get; set; }


        public DbSet<VehicleBrand> VehicleBrands { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }


        public DbSet<CategoryMember> CategoryMembers { get; set; }
        public DbSet<GenderMember> GenderMembers { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<RacingMember> RacingMembers { get; set; }

        public RacingDBContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=practica;Username=postgres;Password=Relax08052003");
        }
    }
}

        