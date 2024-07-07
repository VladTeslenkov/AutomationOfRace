﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RacingPractice;

#nullable disable

namespace RacingPractice.Migrations
{
    [DbContext(typeof(RacingDBContext))]
    [Migration("20240707111527_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CategoryMemberRaceClass", b =>
                {
                    b.Property<int>("CategoryMemberId")
                        .HasColumnType("integer");

                    b.Property<int>("raceClassesId")
                        .HasColumnType("integer");

                    b.HasKey("CategoryMemberId", "raceClassesId");

                    b.HasIndex("raceClassesId");

                    b.ToTable("CategoryMemberRaceClass");
                });

            modelBuilder.Entity("GenderMemberRaceClass", b =>
                {
                    b.Property<int>("GenderMemberId")
                        .HasColumnType("integer");

                    b.Property<int>("RaceClassId")
                        .HasColumnType("integer");

                    b.HasKey("GenderMemberId", "RaceClassId");

                    b.HasIndex("RaceClassId");

                    b.ToTable("GenderMemberRaceClass");
                });

            modelBuilder.Entity("OrganizerRace", b =>
                {
                    b.Property<int>("OrganizerId")
                        .HasColumnType("integer");

                    b.Property<int>("RaceId")
                        .HasColumnType("integer");

                    b.HasKey("OrganizerId", "RaceId");

                    b.HasIndex("RaceId");

                    b.ToTable("OrganizerRace");
                });

            modelBuilder.Entity("RaceTeam", b =>
                {
                    b.Property<int>("RaceId")
                        .HasColumnType("integer");

                    b.Property<int>("TeamsId")
                        .HasColumnType("integer");

                    b.HasKey("RaceId", "TeamsId");

                    b.HasIndex("TeamsId");

                    b.ToTable("RaceTeam");
                });

            modelBuilder.Entity("RacingEntities.Entities.CategoryMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("RacingMemberID")
                        .HasColumnType("integer");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RacingMemberID");

                    b.ToTable("CategoryMember");
                });

            modelBuilder.Entity("RacingEntities.Entities.Citizenship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("integer");

                    b.Property<int?>("RacingMemberID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("RacingMemberID");

                    b.ToTable("Citizenship");
                });

            modelBuilder.Entity("RacingEntities.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("RacingEntities.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("RacingEntities.Entities.Flat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Flat");
                });

            modelBuilder.Entity("RacingEntities.Entities.GenderMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("RacingMemberID")
                        .HasColumnType("integer");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RacingMemberID");

                    b.ToTable("GenderMember");
                });

            modelBuilder.Entity("RacingEntities.Entities.House", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("streetID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("streetID");

                    b.ToTable("House");
                });

            modelBuilder.Entity("RacingEntities.Entities.MemberInfoEntities.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("DocumentTypeIDId")
                        .HasColumnType("integer");

                    b.Property<int?>("DocumentTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("RacingMemberID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DocumentTypeIDId");

                    b.HasIndex("DocumentTypeId");

                    b.HasIndex("RacingMemberID");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("RacingEntities.Entities.MemberInfoEntities.DocumentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DocumentsType");
                });

            modelBuilder.Entity("RacingEntities.Entities.MemberInfoEntities.Link", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Links")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("RacingMemberID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RacingMemberID");

                    b.ToTable("Link");
                });

            modelBuilder.Entity("RacingEntities.Entities.MemberInfoEntities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("BinaryData")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("RacingMemberID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RacingMemberID");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("RacingEntities.Entities.Organizer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("BIK")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CorrespondentAccount")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("INN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KPP")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameHead")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OGRN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OKPO")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OKVED")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PatronymicHead")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PaymentAccount")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SurnameHead")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Organizer");
                });

            modelBuilder.Entity("RacingEntities.Entities.RaceEntities.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("MaxCountMembers")
                        .HasColumnType("integer");

                    b.Property<int>("MinimalCountMembers")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("RaceDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RaceLocation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RegulationLink")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Race");
                });

            modelBuilder.Entity("RacingEntities.Entities.RaceEntities.RaceClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("RaceId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RaceId");

                    b.ToTable("RaceClasse");
                });

            modelBuilder.Entity("RacingEntities.Entities.RaceEntities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("RaceClassId")
                        .HasColumnType("integer");

                    b.Property<string>("TeamPhoto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RaceClassId");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("RacingEntities.Entities.RacingMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<int>("CountryId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Date")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("HouseId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("InsuranceDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsPublicProfile")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameInternational")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PatronymicInternational")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("StreetId")
                        .HasColumnType("integer");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SurnameInternational")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("HouseId");

                    b.HasIndex("StreetId");

                    b.ToTable("RacingMember");
                });

            modelBuilder.Entity("RacingEntities.Entities.Street", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CityID")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CityID");

                    b.ToTable("Street");
                });

            modelBuilder.Entity("RacingEntities.Entities.VehicleInfoEntity.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("EnginePower")
                        .HasColumnType("double precision");

                    b.Property<double>("EngineVolume")
                        .HasColumnType("double precision");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<short>("ProductionYear")
                        .HasColumnType("smallint");

                    b.Property<int?>("brandID")
                        .HasColumnType("integer");

                    b.Property<int?>("modelID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("brandID");

                    b.HasIndex("modelID");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("RacingEntities.Entities.VehicleInfoEntity.VehicleBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("VehicleBrand");
                });

            modelBuilder.Entity("RacingEntities.Entities.VehicleInfoEntity.VehicleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("BrandID")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("VehicleTypeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BrandID");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("VehicleModel");
                });

            modelBuilder.Entity("RacingEntities.Entities.VehicleInfoEntity.VehicleType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("RaceClassId")
                        .HasColumnType("integer");

                    b.Property<int?>("RaceID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RaceClassId");

                    b.HasIndex("RaceID");

                    b.ToTable("VehicleType");
                });

            modelBuilder.Entity("RacingMemberTeam", b =>
                {
                    b.Property<int>("MembersId")
                        .HasColumnType("integer");

                    b.Property<int>("TeamsId")
                        .HasColumnType("integer");

                    b.HasKey("MembersId", "TeamsId");

                    b.HasIndex("TeamsId");

                    b.ToTable("RacingMemberTeam");
                });

            modelBuilder.Entity("RacingMemberVehicle", b =>
                {
                    b.Property<int>("RacingMembersId")
                        .HasColumnType("integer");

                    b.Property<int>("VehiclesId")
                        .HasColumnType("integer");

                    b.HasKey("RacingMembersId", "VehiclesId");

                    b.HasIndex("VehiclesId");

                    b.ToTable("RacingMemberVehicle");
                });

            modelBuilder.Entity("CategoryMemberRaceClass", b =>
                {
                    b.HasOne("RacingEntities.Entities.CategoryMember", null)
                        .WithMany()
                        .HasForeignKey("CategoryMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RacingEntities.Entities.RaceEntities.RaceClass", null)
                        .WithMany()
                        .HasForeignKey("raceClassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GenderMemberRaceClass", b =>
                {
                    b.HasOne("RacingEntities.Entities.GenderMember", null)
                        .WithMany()
                        .HasForeignKey("GenderMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RacingEntities.Entities.RaceEntities.RaceClass", null)
                        .WithMany()
                        .HasForeignKey("RaceClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrganizerRace", b =>
                {
                    b.HasOne("RacingEntities.Entities.Organizer", null)
                        .WithMany()
                        .HasForeignKey("OrganizerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RacingEntities.Entities.RaceEntities.Race", null)
                        .WithMany()
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RaceTeam", b =>
                {
                    b.HasOne("RacingEntities.Entities.RaceEntities.Race", null)
                        .WithMany()
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RacingEntities.Entities.RaceEntities.Team", null)
                        .WithMany()
                        .HasForeignKey("TeamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RacingEntities.Entities.CategoryMember", b =>
                {
                    b.HasOne("RacingEntities.Entities.RacingMember", "RacingMember")
                        .WithMany("CategoryMember")
                        .HasForeignKey("RacingMemberID");

                    b.Navigation("RacingMember");
                });

            modelBuilder.Entity("RacingEntities.Entities.Citizenship", b =>
                {
                    b.HasOne("RacingEntities.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RacingEntities.Entities.RacingMember", "RacingMember")
                        .WithMany("Citizenship")
                        .HasForeignKey("RacingMemberID");

                    b.Navigation("Country");

                    b.Navigation("RacingMember");
                });

            modelBuilder.Entity("RacingEntities.Entities.GenderMember", b =>
                {
                    b.HasOne("RacingEntities.Entities.RacingMember", "RacingMember")
                        .WithMany("GenderMember")
                        .HasForeignKey("RacingMemberID");

                    b.Navigation("RacingMember");
                });

            modelBuilder.Entity("RacingEntities.Entities.House", b =>
                {
                    b.HasOne("RacingEntities.Entities.Street", "street")
                        .WithMany("Houses")
                        .HasForeignKey("streetID");

                    b.Navigation("street");
                });

            modelBuilder.Entity("RacingEntities.Entities.MemberInfoEntities.Document", b =>
                {
                    b.HasOne("RacingEntities.Entities.MemberInfoEntities.DocumentType", "DocumentTypeID")
                        .WithMany()
                        .HasForeignKey("DocumentTypeIDId");

                    b.HasOne("RacingEntities.Entities.MemberInfoEntities.DocumentType", "DocumentType")
                        .WithMany()
                        .HasForeignKey("DocumentTypeId");

                    b.HasOne("RacingEntities.Entities.RacingMember", "RacingMember")
                        .WithMany("Documents")
                        .HasForeignKey("RacingMemberID");

                    b.Navigation("DocumentType");

                    b.Navigation("DocumentTypeID");

                    b.Navigation("RacingMember");
                });

            modelBuilder.Entity("RacingEntities.Entities.MemberInfoEntities.Link", b =>
                {
                    b.HasOne("RacingEntities.Entities.RacingMember", "RacingMember")
                        .WithMany("Links")
                        .HasForeignKey("RacingMemberID");

                    b.Navigation("RacingMember");
                });

            modelBuilder.Entity("RacingEntities.Entities.MemberInfoEntities.Photo", b =>
                {
                    b.HasOne("RacingEntities.Entities.RacingMember", "RacingMember")
                        .WithMany("Photos")
                        .HasForeignKey("RacingMemberID");

                    b.Navigation("RacingMember");
                });

            modelBuilder.Entity("RacingEntities.Entities.RaceEntities.RaceClass", b =>
                {
                    b.HasOne("RacingEntities.Entities.RaceEntities.Race", null)
                        .WithMany("RaceClasses")
                        .HasForeignKey("RaceId");
                });

            modelBuilder.Entity("RacingEntities.Entities.RaceEntities.Team", b =>
                {
                    b.HasOne("RacingEntities.Entities.RaceEntities.RaceClass", null)
                        .WithMany("Teams")
                        .HasForeignKey("RaceClassId");
                });

            modelBuilder.Entity("RacingEntities.Entities.RacingMember", b =>
                {
                    b.HasOne("RacingEntities.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RacingEntities.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RacingEntities.Entities.House", "House")
                        .WithMany()
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RacingEntities.Entities.Street", "Street")
                        .WithMany()
                        .HasForeignKey("StreetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Country");

                    b.Navigation("House");

                    b.Navigation("Street");
                });

            modelBuilder.Entity("RacingEntities.Entities.Street", b =>
                {
                    b.HasOne("RacingEntities.Entities.City", "City")
                        .WithMany("Streets")
                        .HasForeignKey("CityID");

                    b.Navigation("City");
                });

            modelBuilder.Entity("RacingEntities.Entities.VehicleInfoEntity.Vehicle", b =>
                {
                    b.HasOne("RacingEntities.Entities.VehicleInfoEntity.VehicleBrand", "brand")
                        .WithMany()
                        .HasForeignKey("brandID");

                    b.HasOne("RacingEntities.Entities.VehicleInfoEntity.VehicleModel", "model")
                        .WithMany()
                        .HasForeignKey("modelID");

                    b.Navigation("brand");

                    b.Navigation("model");
                });

            modelBuilder.Entity("RacingEntities.Entities.VehicleInfoEntity.VehicleModel", b =>
                {
                    b.HasOne("RacingEntities.Entities.VehicleInfoEntity.VehicleBrand", "Brand")
                        .WithMany("VehicleModels")
                        .HasForeignKey("BrandID");

                    b.HasOne("RacingEntities.Entities.VehicleInfoEntity.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("RacingEntities.Entities.VehicleInfoEntity.VehicleType", b =>
                {
                    b.HasOne("RacingEntities.Entities.RaceEntities.RaceClass", null)
                        .WithMany("VehicleTypes")
                        .HasForeignKey("RaceClassId");

                    b.HasOne("RacingEntities.Entities.RaceEntities.Race", "Race")
                        .WithMany()
                        .HasForeignKey("RaceID");

                    b.Navigation("Race");
                });

            modelBuilder.Entity("RacingMemberTeam", b =>
                {
                    b.HasOne("RacingEntities.Entities.RacingMember", null)
                        .WithMany()
                        .HasForeignKey("MembersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RacingEntities.Entities.RaceEntities.Team", null)
                        .WithMany()
                        .HasForeignKey("TeamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RacingMemberVehicle", b =>
                {
                    b.HasOne("RacingEntities.Entities.RacingMember", null)
                        .WithMany()
                        .HasForeignKey("RacingMembersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RacingEntities.Entities.VehicleInfoEntity.Vehicle", null)
                        .WithMany()
                        .HasForeignKey("VehiclesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RacingEntities.Entities.City", b =>
                {
                    b.Navigation("Streets");
                });

            modelBuilder.Entity("RacingEntities.Entities.RaceEntities.Race", b =>
                {
                    b.Navigation("RaceClasses");
                });

            modelBuilder.Entity("RacingEntities.Entities.RaceEntities.RaceClass", b =>
                {
                    b.Navigation("Teams");

                    b.Navigation("VehicleTypes");
                });

            modelBuilder.Entity("RacingEntities.Entities.RacingMember", b =>
                {
                    b.Navigation("CategoryMember");

                    b.Navigation("Citizenship");

                    b.Navigation("Documents");

                    b.Navigation("GenderMember");

                    b.Navigation("Links");

                    b.Navigation("Photos");
                });

            modelBuilder.Entity("RacingEntities.Entities.Street", b =>
                {
                    b.Navigation("Houses");
                });

            modelBuilder.Entity("RacingEntities.Entities.VehicleInfoEntity.VehicleBrand", b =>
                {
                    b.Navigation("VehicleModels");
                });
#pragma warning restore 612, 618
        }
    }
}
