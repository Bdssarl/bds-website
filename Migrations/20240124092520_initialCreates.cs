using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bds_site_web_version7_.Migrations
{
    /// <inheritdoc />
    public partial class initialCreates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Intitule Mission",
                table: "projet_realises");

            migrationBuilder.DropColumn(
                name: "periode",
                table: "projet_realises");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Intitule Mission",
                table: "projet_realises",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "periode",
                table: "projet_realises",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }
    }
}
