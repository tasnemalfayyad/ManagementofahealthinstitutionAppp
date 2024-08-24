using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplictionData.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Clinicians_ClinicianId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_ClinicianId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ClinicianId",
                table: "Appointments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClinicianId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ClinicianId",
                table: "Appointments",
                column: "ClinicianId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Clinicians_ClinicianId",
                table: "Appointments",
                column: "ClinicianId",
                principalTable: "Clinicians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
