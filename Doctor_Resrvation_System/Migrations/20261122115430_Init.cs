using Microsoft.EntityFrameworkCore.Migrations;
using Doctor_Resrvation_System.Data;
#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Doctor_Resrvation_System.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AppointmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Image", "Name", "PhoneNumber", "Specialization" },
                values: new object[,]
                {
                    { 1, "/images/d1.png", "Dr. Malak Mahmoud", "01000000001", "Cardiology" },
                    { 2, "/images/d2.png", "Dr. Menna Sharaf", "01000000002", "Dermatology" },
                    { 3, "/images/d3.png", "Dr. Doaa Badawy", "01000000003", "Pediatrics" },
                    { 4, "/images/d4.png", "Dr. Layla Yasser", "01000000004", "Dentistry" },
                    { 5, "/images/d5.png", "Dr. Amr El-Sayed", "01000000005", "Orthopedics" },
                    { 6, "/images/d6.png", "Dr. Mohamed Ibrahim", "01000000006", "Neurology" },
                    { 7, "/images/d7.png", "Dr. Youssef Osama", "01000000007", "Ophthalmology" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "Day", "DoctorId", "Time" },
                values: new object[,]
                {
                    { 1, "Sunday", 1, "10:00" },
                    { 2, "Monday", 1, "12:00" },
                    { 3, "Wednesday", 1, "09:00" },
                    { 4, "Thursday", 1, "14:00" },
                    { 5, "Sunday", 2, "11:00" },
                    { 6, "Tuesday", 2, "09:00" },
                    { 7, "Wednesday", 2, "15:00" },
                    { 8, "Thursday", 2, "10:00" },
                    { 9, "Sunday", 3, "13:00" },
                    { 10, "Monday", 3, "10:00" },
                    { 11, "Wednesday", 3, "13:00" },
                    { 12, "Thursday", 3, "16:00" },
                    { 13, "Monday", 4, "15:00" },
                    { 14, "Tuesday", 4, "11:00" },
                    { 15, "Wednesday", 4, "12:00" },
                    { 16, "Thursday", 4, "14:00" },
                    { 17, "Sunday", 5, "15:00" },
                    { 18, "Monday", 5, "09:00" },
                    { 19, "Wednesday", 5, "10:00" },
                    { 20, "Thursday", 5, "13:00" },
                    { 21, "Sunday", 6, "12:00" },
                    { 22, "Monday", 6, "16:00" },
                    { 23, "Tuesday", 6, "14:00" },
                    { 24, "Thursday", 6, "12:00" },
                    { 25, "Sunday", 7, "09:00" },
                    { 26, "Tuesday", 7, "13:00" },
                    { 27, "Wednesday", 7, "11:00" },
                    { 28, "Thursday", 7, "15:00" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_AppointmentId",
                table: "Bookings",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}
