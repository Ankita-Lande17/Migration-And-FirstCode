using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationsAndCodeFirst.Migrations
{
    public partial class UpdateStudentMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "StudentMaster",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StandardId",
                table: "StudentMaster",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Standards",
                columns: table => new
                {
                    StandardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StandardName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Standards", x => x.StandardId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentMaster_StandardId",
                table: "StudentMaster",
                column: "StandardId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentMaster_Standards_StandardId",
                table: "StudentMaster",
                column: "StandardId",
                principalTable: "Standards",
                principalColumn: "StandardId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentMaster_Standards_StandardId",
                table: "StudentMaster");

            migrationBuilder.DropTable(
                name: "Standards");

            migrationBuilder.DropIndex(
                name: "IX_StudentMaster_StandardId",
                table: "StudentMaster");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "StudentMaster");

            migrationBuilder.DropColumn(
                name: "StandardId",
                table: "StudentMaster");
        }
    }
}
