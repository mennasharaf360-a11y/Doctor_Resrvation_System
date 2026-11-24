using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Doctor_Resrvation_System.Migrations
{
    /// <inheritdoc />
    public partial class AddDoctorSubSpecialization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubSpecialization",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubSpecialization",
                value: "Interventional Cardiology");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubSpecialization",
                value: "Cosmetic Dermatology");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "SubSpecialization",
                value: "Neonatology");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "SubSpecialization",
                value: "Orthodontics");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "SubSpecialization",
                value: "Sports Medicine");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "SubSpecialization",
                value: "Stroke Neurology");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "SubSpecialization",
                value: "Retina");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubSpecialization",
                table: "Doctors");
        }
    }
}
