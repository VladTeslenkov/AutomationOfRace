
using Microsoft.EntityFrameworkCore;
using RacingEntities.Entities;
using RacingEntities.Entities.MemberInfoEntities;
using RacingEntities.Entities.RaceEntities;
using RacingEntities.Entities.VehicleInfoEntity;

namespace RacingPractice
{
    public class RacingDBContext:DbContext
    {
        public DbSet<Document> Document { get; set; }
        public DbSet<DocumentType> DocumentsType { get; set; }
        public DbSet<Link> Link { get; set; }
        public DbSet<Photo> Photo { get; set; }


        public DbSet<Citizenship> Citizenship { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Flat> Flat { get; set; }
        public DbSet<House> House { get; set; }
        public DbSet<Street> Street { get; set; }


        public DbSet<RaceClass> RaceClasse { get; set; }
        public DbSet<Race> Race { get; set; }
        public DbSet<Team> Team { get; set; }


        public DbSet<VehicleBrand> VehicleBrand { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<VehicleModel> VehicleModel { get; set; }
        public DbSet<VehicleType> VehicleType { get; set; }


        public DbSet<CategoryMember> CategoryMember{ get; set; }
        public DbSet<GenderMember> GenderMember { get; set; }
        public DbSet<Organizer> Organizer { get; set; }
        
        public DbSet<RacingMember> RacingMember { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=practica;Username=postgres;Password=Relax08052003");
        }

    }
}

        