using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bds_site_web_version7_.Migrations
{
    /// <inheritdoc />
    public partial class actualite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "nompage_Actualite",
                table: "actualite",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nompage_Actualite",
                table: "actualite");
        }
    }
}
