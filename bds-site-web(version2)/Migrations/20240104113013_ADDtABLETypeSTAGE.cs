using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bds_site_web_version2_.Migrations
{
    /// <inheritdoc />
    public partial class ADDtABLETypeSTAGE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type_stage",
                table: "stage");

            migrationBuilder.CreateTable(
                name: "TypeStage",
                columns: table => new
                {
                    id_TypeStage = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    Libelelle_TypeStage = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_TypeStage);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StageTypeStages",
                columns: table => new
                {
                    StagesIdStage = table.Column<string>(type: "varchar(25)", nullable: false),
                    TypeStagesIdTypeStage = table.Column<string>(type: "varchar(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StageTypeStages", x => new { x.StagesIdStage, x.TypeStagesIdTypeStage });
                    table.ForeignKey(
                        name: "FK_StageTypeStages_TypeStage_TypeStagesIdTypeStage",
                        column: x => x.TypeStagesIdTypeStage,
                        principalTable: "TypeStage",
                        principalColumn: "id_TypeStage",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StageTypeStages_stage_StagesIdStage",
                        column: x => x.StagesIdStage,
                        principalTable: "stage",
                        principalColumn: "id_Stage",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_StageTypeStages_TypeStagesIdTypeStage",
                table: "StageTypeStages",
                column: "TypeStagesIdTypeStage");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StageTypeStages");

            migrationBuilder.DropTable(
                name: "TypeStage");

            migrationBuilder.AddColumn<string>(
                name: "type_stage",
                table: "stage",
                type: "varchar(45)",
                maxLength: 45,
                nullable: false,
                defaultValue: "");
        }
    }
}
