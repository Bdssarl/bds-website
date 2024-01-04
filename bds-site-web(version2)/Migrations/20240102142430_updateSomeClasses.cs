using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bds_site_web_version2_.Migrations
{
    /// <inheritdoc />
    public partial class updateSomeClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageDemandeStage",
                table: "DemandeStages");

            migrationBuilder.DropColumn(
                name: "Periode",
                table: "DemandeStages");

            migrationBuilder.DropColumn(
                name: "TypeEmploi",
                table: "DemandeStages");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MessageDemandeStage",
                table: "DemandeStages",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Periode",
                table: "DemandeStages",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "TypeEmploi",
                table: "DemandeStages",
                type: "longtext",
                nullable: false);
        }
    }
}
