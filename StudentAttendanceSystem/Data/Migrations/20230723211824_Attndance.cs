using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentAttendanceSystem.Data.Migrations
{
    public partial class Attndance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_User_UserStudentIdId",
                table: "Attendance");

            migrationBuilder.DropIndex(
                name: "IX_Attendance_UserStudentIdId",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "UserStudentIdId",
                table: "Attendance");

            migrationBuilder.AddColumn<string>(
                name: "UserStudentId",
                table: "Attendance",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserStudentId",
                table: "Attendance");

            migrationBuilder.AddColumn<int>(
                name: "UserStudentIdId",
                table: "Attendance",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_UserStudentIdId",
                table: "Attendance",
                column: "UserStudentIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_User_UserStudentIdId",
                table: "Attendance",
                column: "UserStudentIdId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
