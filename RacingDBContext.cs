
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
        public DbSet<DocumentEntity> Documents { get; set; }
        public DbSet<DocumentTypeEntity> DocumentsType { get; set; }
        public DbSet<LinkEntity> Links { get; set; }
        public DbSet<PhotoEntity> Photos { get; set; }


        public DbSet<CitizenshipEntity> Citizenships { get; set; }
        public DbSet<CityEntity> City { get; set; }
        public DbSet<CountryEntity> Countries { get; set; }
        public DbSet<FlatEntity> Flats { get; set; }
        public DbSet<HouseEntity> Houses { get; set; }
        public DbSet<StreetEntity> Streets { get; set; }


        public DbSet<RaceClassEntity> RaceClasses { get; set; }
        public DbSet<RaceEntity> Races { get; set; }
        public DbSet<TeamEntity> Teams { get; set; }


        public DbSet<VehicleBrandEntity> VehicleBrands { get; set; }
        public DbSet<VehicleEntity> Vehicles { get; set; }
        public DbSet<VehicleModelEntity> VehicleModels { get; set; }
        public DbSet<VehicleTypeEntity> VehicleTypes { get; set; }


        public DbSet<CategoryMember> CategoryMembers { get; set; }
        public DbSet<GenderMemberEntity> GenderMembers { get; set; }
        public DbSet<OrganizerEntity> Organizers { get; set; }
        public DbSet<RacingMemberEntity> RacingMembers { get; set; }

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

        