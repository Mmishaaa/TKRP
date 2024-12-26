using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportComplex.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coaches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coaches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FootballEquipments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PricePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballEquipments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FootballFields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PricePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballFields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GolfCourts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PricePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GolfCourts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GolfEquipments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PricePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GolfEquipments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PingPongEquipments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PricePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PingPongEquipments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PingPongTables",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PricePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PingPongTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SwimmingPoolEquipments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PricePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SwimmingPoolEquipments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SwimmingPools",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PricePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SwimmingPools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TennisCourts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PricePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisCourts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TennisEquipments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PricePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisEquipments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FootballBookings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartsAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndsAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FootballFieldId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FootbalEquipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballBookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballBookings_Coaches_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coaches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FootballBookings_FootballEquipments_FootbalEquipmentId",
                        column: x => x.FootbalEquipmentId,
                        principalTable: "FootballEquipments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FootballBookings_FootballFields_FootballFieldId",
                        column: x => x.FootballFieldId,
                        principalTable: "FootballFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballBookings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GolfBookings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartsAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndsAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GolfCourtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GolfEquipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GolfBookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GolfBookings_Coaches_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coaches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GolfBookings_GolfCourts_GolfCourtId",
                        column: x => x.GolfCourtId,
                        principalTable: "GolfCourts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GolfBookings_GolfEquipments_GolfEquipmentId",
                        column: x => x.GolfEquipmentId,
                        principalTable: "GolfEquipments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GolfBookings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PingPongBookings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartsAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndsAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PingPongTableId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PingPongEquipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PingPongBookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PingPongBookings_Coaches_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coaches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PingPongBookings_PingPongEquipments_PingPongEquipmentId",
                        column: x => x.PingPongEquipmentId,
                        principalTable: "PingPongEquipments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PingPongBookings_PingPongTables_PingPongTableId",
                        column: x => x.PingPongTableId,
                        principalTable: "PingPongTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PingPongBookings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StarsCount = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoachId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Coaches_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coaches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SwimmingPoolBookings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartsAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndsAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SwimmingPoolId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SwimmingPoolEquipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SwimmingPoolBookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SwimmingPoolBookings_Coaches_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coaches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SwimmingPoolBookings_SwimmingPoolEquipments_SwimmingPoolEquipmentId",
                        column: x => x.SwimmingPoolEquipmentId,
                        principalTable: "SwimmingPoolEquipments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SwimmingPoolBookings_SwimmingPools_SwimmingPoolId",
                        column: x => x.SwimmingPoolId,
                        principalTable: "SwimmingPools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SwimmingPoolBookings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TennisBookings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartsAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndsAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TennisCourtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TennisEquipmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisBookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TennisBookings_Coaches_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coaches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisBookings_TennisCourts_TennisCourtId",
                        column: x => x.TennisCourtId,
                        principalTable: "TennisCourts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TennisBookings_TennisEquipments_TennisEquipmentId",
                        column: x => x.TennisEquipmentId,
                        principalTable: "TennisEquipments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TennisBookings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FootballBookings_CoachId",
                table: "FootballBookings",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballBookings_FootbalEquipmentId",
                table: "FootballBookings",
                column: "FootbalEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballBookings_FootballFieldId",
                table: "FootballBookings",
                column: "FootballFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballBookings_UserId",
                table: "FootballBookings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GolfBookings_CoachId",
                table: "GolfBookings",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_GolfBookings_GolfCourtId",
                table: "GolfBookings",
                column: "GolfCourtId");

            migrationBuilder.CreateIndex(
                name: "IX_GolfBookings_GolfEquipmentId",
                table: "GolfBookings",
                column: "GolfEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_GolfBookings_UserId",
                table: "GolfBookings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PingPongBookings_CoachId",
                table: "PingPongBookings",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_PingPongBookings_PingPongEquipmentId",
                table: "PingPongBookings",
                column: "PingPongEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PingPongBookings_PingPongTableId",
                table: "PingPongBookings",
                column: "PingPongTableId");

            migrationBuilder.CreateIndex(
                name: "IX_PingPongBookings_UserId",
                table: "PingPongBookings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CoachId",
                table: "Reviews",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SwimmingPoolBookings_CoachId",
                table: "SwimmingPoolBookings",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_SwimmingPoolBookings_SwimmingPoolEquipmentId",
                table: "SwimmingPoolBookings",
                column: "SwimmingPoolEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SwimmingPoolBookings_SwimmingPoolId",
                table: "SwimmingPoolBookings",
                column: "SwimmingPoolId");

            migrationBuilder.CreateIndex(
                name: "IX_SwimmingPoolBookings_UserId",
                table: "SwimmingPoolBookings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TennisBookings_CoachId",
                table: "TennisBookings",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_TennisBookings_TennisCourtId",
                table: "TennisBookings",
                column: "TennisCourtId");

            migrationBuilder.CreateIndex(
                name: "IX_TennisBookings_TennisEquipmentId",
                table: "TennisBookings",
                column: "TennisEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TennisBookings_UserId",
                table: "TennisBookings",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FootballBookings");

            migrationBuilder.DropTable(
                name: "GolfBookings");

            migrationBuilder.DropTable(
                name: "PingPongBookings");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "SwimmingPoolBookings");

            migrationBuilder.DropTable(
                name: "TennisBookings");

            migrationBuilder.DropTable(
                name: "FootballEquipments");

            migrationBuilder.DropTable(
                name: "FootballFields");

            migrationBuilder.DropTable(
                name: "GolfCourts");

            migrationBuilder.DropTable(
                name: "GolfEquipments");

            migrationBuilder.DropTable(
                name: "PingPongEquipments");

            migrationBuilder.DropTable(
                name: "PingPongTables");

            migrationBuilder.DropTable(
                name: "SwimmingPoolEquipments");

            migrationBuilder.DropTable(
                name: "SwimmingPools");

            migrationBuilder.DropTable(
                name: "Coaches");

            migrationBuilder.DropTable(
                name: "TennisCourts");

            migrationBuilder.DropTable(
                name: "TennisEquipments");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
