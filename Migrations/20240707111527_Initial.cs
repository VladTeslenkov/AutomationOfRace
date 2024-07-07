using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RacingPractice.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentsType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentsType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organizer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    OGRN = table.Column<string>(type: "text", nullable: false),
                    INN = table.Column<string>(type: "text", nullable: false),
                    KPP = table.Column<string>(type: "text", nullable: false),
                    OKPO = table.Column<string>(type: "text", nullable: false),
                    OKVED = table.Column<string>(type: "text", nullable: false),
                    PaymentAccount = table.Column<string>(type: "text", nullable: false),
                    CorrespondentAccount = table.Column<string>(type: "text", nullable: false),
                    BIK = table.Column<string>(type: "text", nullable: false),
                    SurnameHead = table.Column<string>(type: "text", nullable: false),
                    NameHead = table.Column<string>(type: "text", nullable: false),
                    PatronymicHead = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Race",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    RaceLocation = table.Column<string>(type: "text", nullable: false),
                    RaceDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MaxCountMembers = table.Column<int>(type: "integer", nullable: false),
                    MinimalCountMembers = table.Column<int>(type: "integer", nullable: false),
                    RegulationLink = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Race", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleBrand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBrand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Street",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CityID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Street", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Street_City_CityID",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrganizerRace",
                columns: table => new
                {
                    OrganizerId = table.Column<int>(type: "integer", nullable: false),
                    RaceId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizerRace", x => new { x.OrganizerId, x.RaceId });
                    table.ForeignKey(
                        name: "FK_OrganizerRace_Organizer_OrganizerId",
                        column: x => x.OrganizerId,
                        principalTable: "Organizer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrganizerRace_Race_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Race",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceClasse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    RaceId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceClasse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RaceClasse_Race_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Race",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "House",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HouseNumber = table.Column<string>(type: "text", nullable: false),
                    streetID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_House", x => x.Id);
                    table.ForeignKey(
                        name: "FK_House_Street_streetID",
                        column: x => x.streetID,
                        principalTable: "Street",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    TeamPhoto = table.Column<string>(type: "text", nullable: false),
                    RaceClassId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Team_RaceClasse_RaceClassId",
                        column: x => x.RaceClassId,
                        principalTable: "RaceClasse",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    RaceID = table.Column<int>(type: "integer", nullable: true),
                    RaceClassId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleType_RaceClasse_RaceClassId",
                        column: x => x.RaceClassId,
                        principalTable: "RaceClasse",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleType_Race_RaceID",
                        column: x => x.RaceID,
                        principalTable: "Race",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RacingMember",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    Patronymic = table.Column<string>(type: "text", nullable: false),
                    NameInternational = table.Column<string>(type: "text", nullable: false),
                    SurnameInternational = table.Column<string>(type: "text", nullable: false),
                    PatronymicInternational = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsPublicProfile = table.Column<bool>(type: "boolean", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    InsuranceDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CountryId = table.Column<int>(type: "integer", nullable: false),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    HouseId = table.Column<int>(type: "integer", nullable: false),
                    StreetId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RacingMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RacingMember_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RacingMember_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RacingMember_House_HouseId",
                        column: x => x.HouseId,
                        principalTable: "House",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RacingMember_Street_StreetId",
                        column: x => x.StreetId,
                        principalTable: "Street",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceTeam",
                columns: table => new
                {
                    RaceId = table.Column<int>(type: "integer", nullable: false),
                    TeamsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceTeam", x => new { x.RaceId, x.TeamsId });
                    table.ForeignKey(
                        name: "FK_RaceTeam_Race_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Race",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceTeam_Team_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    VehicleTypeId = table.Column<int>(type: "integer", nullable: false),
                    BrandID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleModel_VehicleBrand_BrandID",
                        column: x => x.BrandID,
                        principalTable: "VehicleBrand",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleModel_VehicleType_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryMember",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ShortName = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    RacingMemberID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryMember_RacingMember_RacingMemberID",
                        column: x => x.RacingMemberID,
                        principalTable: "RacingMember",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Citizenship",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CountryId = table.Column<int>(type: "integer", nullable: false),
                    RacingMemberID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizenship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citizenship_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Citizenship_RacingMember_RacingMemberID",
                        column: x => x.RacingMemberID,
                        principalTable: "RacingMember",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DocumentTypeId = table.Column<int>(type: "integer", nullable: true),
                    DocumentTypeIDId = table.Column<int>(type: "integer", nullable: true),
                    RacingMemberID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Document_DocumentsType_DocumentTypeIDId",
                        column: x => x.DocumentTypeIDId,
                        principalTable: "DocumentsType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Document_DocumentsType_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentsType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Document_RacingMember_RacingMemberID",
                        column: x => x.RacingMemberID,
                        principalTable: "RacingMember",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GenderMember",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ShortName = table.Column<string>(type: "text", nullable: false),
                    RacingMemberID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenderMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenderMember_RacingMember_RacingMemberID",
                        column: x => x.RacingMemberID,
                        principalTable: "RacingMember",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Link",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Links = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    RacingMemberID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Link", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Link_RacingMember_RacingMemberID",
                        column: x => x.RacingMemberID,
                        principalTable: "RacingMember",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BinaryData = table.Column<string>(type: "text", nullable: false),
                    RacingMemberID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photo_RacingMember_RacingMemberID",
                        column: x => x.RacingMemberID,
                        principalTable: "RacingMember",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RacingMemberTeam",
                columns: table => new
                {
                    MembersId = table.Column<int>(type: "integer", nullable: false),
                    TeamsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RacingMemberTeam", x => new { x.MembersId, x.TeamsId });
                    table.ForeignKey(
                        name: "FK_RacingMemberTeam_RacingMember_MembersId",
                        column: x => x.MembersId,
                        principalTable: "RacingMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RacingMemberTeam_Team_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    brandID = table.Column<int>(type: "integer", nullable: true),
                    modelID = table.Column<int>(type: "integer", nullable: true),
                    EnginePower = table.Column<double>(type: "double precision", nullable: false),
                    EngineVolume = table.Column<double>(type: "double precision", nullable: false),
                    ProductionYear = table.Column<short>(type: "smallint", nullable: false),
                    ModelName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleBrand_brandID",
                        column: x => x.brandID,
                        principalTable: "VehicleBrand",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleModel_modelID",
                        column: x => x.modelID,
                        principalTable: "VehicleModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CategoryMemberRaceClass",
                columns: table => new
                {
                    CategoryMemberId = table.Column<int>(type: "integer", nullable: false),
                    raceClassesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryMemberRaceClass", x => new { x.CategoryMemberId, x.raceClassesId });
                    table.ForeignKey(
                        name: "FK_CategoryMemberRaceClass_CategoryMember_CategoryMemberId",
                        column: x => x.CategoryMemberId,
                        principalTable: "CategoryMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryMemberRaceClass_RaceClasse_raceClassesId",
                        column: x => x.raceClassesId,
                        principalTable: "RaceClasse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenderMemberRaceClass",
                columns: table => new
                {
                    GenderMemberId = table.Column<int>(type: "integer", nullable: false),
                    RaceClassId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenderMemberRaceClass", x => new { x.GenderMemberId, x.RaceClassId });
                    table.ForeignKey(
                        name: "FK_GenderMemberRaceClass_GenderMember_GenderMemberId",
                        column: x => x.GenderMemberId,
                        principalTable: "GenderMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenderMemberRaceClass_RaceClasse_RaceClassId",
                        column: x => x.RaceClassId,
                        principalTable: "RaceClasse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RacingMemberVehicle",
                columns: table => new
                {
                    RacingMembersId = table.Column<int>(type: "integer", nullable: false),
                    VehiclesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RacingMemberVehicle", x => new { x.RacingMembersId, x.VehiclesId });
                    table.ForeignKey(
                        name: "FK_RacingMemberVehicle_RacingMember_RacingMembersId",
                        column: x => x.RacingMembersId,
                        principalTable: "RacingMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RacingMemberVehicle_Vehicle_VehiclesId",
                        column: x => x.VehiclesId,
                        principalTable: "Vehicle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryMember_RacingMemberID",
                table: "CategoryMember",
                column: "RacingMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryMemberRaceClass_raceClassesId",
                table: "CategoryMemberRaceClass",
                column: "raceClassesId");

            migrationBuilder.CreateIndex(
                name: "IX_Citizenship_CountryId",
                table: "Citizenship",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Citizenship_RacingMemberID",
                table: "Citizenship",
                column: "RacingMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Document_DocumentTypeId",
                table: "Document",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_DocumentTypeIDId",
                table: "Document",
                column: "DocumentTypeIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_RacingMemberID",
                table: "Document",
                column: "RacingMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_GenderMember_RacingMemberID",
                table: "GenderMember",
                column: "RacingMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_GenderMemberRaceClass_RaceClassId",
                table: "GenderMemberRaceClass",
                column: "RaceClassId");

            migrationBuilder.CreateIndex(
                name: "IX_House_streetID",
                table: "House",
                column: "streetID");

            migrationBuilder.CreateIndex(
                name: "IX_Link_RacingMemberID",
                table: "Link",
                column: "RacingMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizerRace_RaceId",
                table: "OrganizerRace",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_RacingMemberID",
                table: "Photo",
                column: "RacingMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_RaceClasse_RaceId",
                table: "RaceClasse",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceTeam_TeamsId",
                table: "RaceTeam",
                column: "TeamsId");

            migrationBuilder.CreateIndex(
                name: "IX_RacingMember_CityId",
                table: "RacingMember",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_RacingMember_CountryId",
                table: "RacingMember",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_RacingMember_HouseId",
                table: "RacingMember",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_RacingMember_StreetId",
                table: "RacingMember",
                column: "StreetId");

            migrationBuilder.CreateIndex(
                name: "IX_RacingMemberTeam_TeamsId",
                table: "RacingMemberTeam",
                column: "TeamsId");

            migrationBuilder.CreateIndex(
                name: "IX_RacingMemberVehicle_VehiclesId",
                table: "RacingMemberVehicle",
                column: "VehiclesId");

            migrationBuilder.CreateIndex(
                name: "IX_Street_CityID",
                table: "Street",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Team_RaceClassId",
                table: "Team",
                column: "RaceClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_brandID",
                table: "Vehicle",
                column: "brandID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_modelID",
                table: "Vehicle",
                column: "modelID");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModel_BrandID",
                table: "VehicleModel",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModel_VehicleTypeId",
                table: "VehicleModel",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleType_RaceClassId",
                table: "VehicleType",
                column: "RaceClassId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleType_RaceID",
                table: "VehicleType",
                column: "RaceID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryMemberRaceClass");

            migrationBuilder.DropTable(
                name: "Citizenship");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "Flat");

            migrationBuilder.DropTable(
                name: "GenderMemberRaceClass");

            migrationBuilder.DropTable(
                name: "Link");

            migrationBuilder.DropTable(
                name: "OrganizerRace");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "RaceTeam");

            migrationBuilder.DropTable(
                name: "RacingMemberTeam");

            migrationBuilder.DropTable(
                name: "RacingMemberVehicle");

            migrationBuilder.DropTable(
                name: "CategoryMember");

            migrationBuilder.DropTable(
                name: "DocumentsType");

            migrationBuilder.DropTable(
                name: "GenderMember");

            migrationBuilder.DropTable(
                name: "Organizer");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "RacingMember");

            migrationBuilder.DropTable(
                name: "VehicleModel");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "House");

            migrationBuilder.DropTable(
                name: "VehicleBrand");

            migrationBuilder.DropTable(
                name: "VehicleType");

            migrationBuilder.DropTable(
                name: "Street");

            migrationBuilder.DropTable(
                name: "RaceClasse");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Race");
        }
    }
}
