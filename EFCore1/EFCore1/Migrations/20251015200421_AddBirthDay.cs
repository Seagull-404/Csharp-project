using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore1.Migrations
{
    /// <inheritdoc />
    public partial class AddBirthDay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Birthday",
                table: "T_Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "T_Persons");
        }
    }
}
