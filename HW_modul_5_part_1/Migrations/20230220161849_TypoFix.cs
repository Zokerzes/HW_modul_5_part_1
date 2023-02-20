using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW_modul_5_part_1.Migrations
{
    /// <inheritdoc />
    public partial class TypoFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PartOfWord",
                table: "Countries",
                newName: "PartOfWorld");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PartOfWorld",
                table: "Countries",
                newName: "PartOfWord");
        }
    }
}
