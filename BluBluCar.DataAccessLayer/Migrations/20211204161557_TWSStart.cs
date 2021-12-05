using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TWS.DataAccessLayer.Migrations
{
    public partial class TWSStart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfRegistration = table.Column<DateTime>(type: "datetime2", nullable: false, computedColumnSql: "GETDATE()"),
                    Gender = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false, defaultValue: "None"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DriverAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverExperience = table.Column<int>(type: "int", nullable: false),
                    UserAccountForeignKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DriverAccounts_Users_UserAccountForeignKey",
                        column: x => x.UserAccountForeignKey,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TravelerAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TravelExperience = table.Column<int>(type: "int", nullable: false),
                    UserAccountForeignKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelerAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TravelerAccounts_Users_UserAccountForeignKey",
                        column: x => x.UserAccountForeignKey,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarBrand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CarModel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NumberOfSeats = table.Column<int>(type: "int", nullable: false),
                    DriverAccountForeignKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transports_DriverAccounts_DriverAccountForeignKey",
                        column: x => x.DriverAccountForeignKey,
                        principalTable: "DriverAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceOfDeparture = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PlaceOfArrival = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TimeOfDeparture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeOfArrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfFreeSeats = table.Column<byte>(type: "tinyint", nullable: false),
                    DriverAccountForeignKey = table.Column<int>(type: "int", nullable: true),
                    TravelerAccountForeignKey = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trips_DriverAccounts_DriverAccountForeignKey",
                        column: x => x.DriverAccountForeignKey,
                        principalTable: "DriverAccounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trips_TravelerAccounts_TravelerAccountForeignKey",
                        column: x => x.TravelerAccountForeignKey,
                        principalTable: "TravelerAccounts",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(1971, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chris", "male", "Evans", "+380965433214" },
                    { 2, new DateTime(1978, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johny", "male", "Depp", "+380965433463" },
                    { 3, new DateTime(1969, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Will", "male", "Smith", "+380965437645" },
                    { 4, new DateTime(1969, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert", "male", "Downey", "+380965433421" },
                    { 5, new DateTime(1985, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keanu", "male", "Reevs", "+380965454374" }
                });

            migrationBuilder.InsertData(
                table: "DriverAccounts",
                columns: new[] { "Id", "DriverExperience", "UserAccountForeignKey" },
                values: new object[,]
                {
                    { 1, 20, 1 },
                    { 2, 5, 2 }
                });

            migrationBuilder.InsertData(
                table: "TravelerAccounts",
                columns: new[] { "Id", "TravelExperience", "UserAccountForeignKey" },
                values: new object[,]
                {
                    { 1, 3, 3 },
                    { 2, 7, 4 }
                });

            migrationBuilder.InsertData(
                table: "Transports",
                columns: new[] { "Id", "CarBrand", "CarModel", "DriverAccountForeignKey", "NumberOfSeats" },
                values: new object[,]
                {
                    { 1, "BMW", "X5", 1, 3 },
                    { 2, "Audi", "A7", 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "DriverAccountForeignKey", "NumberOfFreeSeats", "PlaceOfArrival", "PlaceOfDeparture", "TimeOfArrival", "TimeOfDeparture", "TravelerAccountForeignKey" },
                values: new object[,]
                {
                    { 1, 1, (byte)1, "Lviv", "Chernivtsi", new DateTime(2021, 12, 4, 21, 15, 56, 652, DateTimeKind.Local).AddTicks(259), new DateTime(2021, 12, 4, 18, 15, 56, 615, DateTimeKind.Local).AddTicks(6967), 1 },
                    { 2, 1, (byte)3, "Ivano-Frankivsk", "Lviv", new DateTime(2021, 12, 6, 21, 15, 56, 652, DateTimeKind.Local).AddTicks(1635), new DateTime(2021, 12, 6, 18, 15, 56, 652, DateTimeKind.Local).AddTicks(1612), null },
                    { 3, 2, (byte)3, "Kyiw", "Odessa", new DateTime(2021, 12, 6, 18, 15, 56, 652, DateTimeKind.Local).AddTicks(1642), new DateTime(2021, 12, 5, 18, 15, 56, 652, DateTimeKind.Local).AddTicks(1640), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DriverAccounts_UserAccountForeignKey",
                table: "DriverAccounts",
                column: "UserAccountForeignKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transports_DriverAccountForeignKey",
                table: "Transports",
                column: "DriverAccountForeignKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TravelerAccounts_UserAccountForeignKey",
                table: "TravelerAccounts",
                column: "UserAccountForeignKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trips_DriverAccountForeignKey",
                table: "Trips",
                column: "DriverAccountForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_TravelerAccountForeignKey",
                table: "Trips",
                column: "TravelerAccountForeignKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transports");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "DriverAccounts");

            migrationBuilder.DropTable(
                name: "TravelerAccounts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
