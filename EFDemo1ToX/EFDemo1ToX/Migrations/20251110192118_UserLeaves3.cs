using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDemo1ToX.Migrations
{
    public partial class UserLeaves3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Leaves_T_Users_ApproverId",
                table: "T_Leaves");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Leaves_T_Users_RequesterId",
                table: "T_Leaves");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Leaves_T_Users_ApproverId",
                table: "T_Leaves",
                column: "ApproverId",
                principalTable: "T_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Leaves_T_Users_RequesterId",
                table: "T_Leaves",
                column: "RequesterId",
                principalTable: "T_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Leaves_T_Users_ApproverId",
                table: "T_Leaves");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Leaves_T_Users_RequesterId",
                table: "T_Leaves");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Leaves_T_Users_ApproverId",
                table: "T_Leaves",
                column: "ApproverId",
                principalTable: "T_Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Leaves_T_Users_RequesterId",
                table: "T_Leaves",
                column: "RequesterId",
                principalTable: "T_Users",
                principalColumn: "Id");
        }
    }
}
