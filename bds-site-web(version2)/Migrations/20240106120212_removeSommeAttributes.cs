using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bds_site_web_version2_.Migrations
{
    /// <inheritdoc />
    public partial class removeSommeAttributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DemandeStages_stage_IdStageNavigationIdStage",
                table: "DemandeStages");

            migrationBuilder.RenameColumn(
                name: "IdStageNavigationIdStage",
                table: "DemandeStages",
                newName: "StagesIdStage");

            migrationBuilder.AddColumn<string>(
                name: "DemandeStageStagesIdStage",
                table: "stage",
                type: "varchar(25)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DemandeStageUsersId",
                table: "stage",
                type: "varchar(255)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DemandeStageStagesIdStage",
                table: "AspNetUsers",
                type: "varchar(25)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DemandeStageUsersId",
                table: "AspNetUsers",
                type: "varchar(255)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_stage_DemandeStageStagesIdStage_DemandeStageUsersId",
                table: "stage",
                columns: new[] { "DemandeStageStagesIdStage", "DemandeStageUsersId" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DemandeStageStagesIdStage_DemandeStageUsersId",
                table: "AspNetUsers",
                columns: new[] { "DemandeStageStagesIdStage", "DemandeStageUsersId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_DemandeStages_DemandeStageStagesIdStage_DemandeS~",
                table: "AspNetUsers",
                columns: new[] { "DemandeStageStagesIdStage", "DemandeStageUsersId" },
                principalTable: "DemandeStages",
                principalColumns: new[] { "StagesIdStage", "UsersId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DemandeStages_stage_StagesIdStage",
                table: "DemandeStages",
                column: "StagesIdStage",
                principalTable: "stage",
                principalColumn: "id_Stage",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_stage_DemandeStages_DemandeStageStagesIdStage_DemandeStageUs~",
                table: "stage",
                columns: new[] { "DemandeStageStagesIdStage", "DemandeStageUsersId" },
                principalTable: "DemandeStages",
                principalColumns: new[] { "StagesIdStage", "UsersId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_DemandeStages_DemandeStageStagesIdStage_DemandeS~",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_DemandeStages_stage_StagesIdStage",
                table: "DemandeStages");

            migrationBuilder.DropForeignKey(
                name: "FK_stage_DemandeStages_DemandeStageStagesIdStage_DemandeStageUs~",
                table: "stage");

            migrationBuilder.DropIndex(
                name: "IX_stage_DemandeStageStagesIdStage_DemandeStageUsersId",
                table: "stage");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DemandeStageStagesIdStage_DemandeStageUsersId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DemandeStageStagesIdStage",
                table: "stage");

            migrationBuilder.DropColumn(
                name: "DemandeStageUsersId",
                table: "stage");

            migrationBuilder.DropColumn(
                name: "DemandeStageStagesIdStage",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DemandeStageUsersId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "StagesIdStage",
                table: "DemandeStages",
                newName: "IdStageNavigationIdStage");

            migrationBuilder.AddForeignKey(
                name: "FK_DemandeStages_stage_IdStageNavigationIdStage",
                table: "DemandeStages",
                column: "IdStageNavigationIdStage",
                principalTable: "stage",
                principalColumn: "id_Stage",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
