using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dynamic_User_Defined_Dashboards.Migrations
{
    /// <inheritdoc />
    public partial class MigrateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Dashboard_Tutorial");

            migrationBuilder.CreateTable(
                name: "DashboardLinkedElements",
                schema: "Dashboard_Tutorial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DashboardId = table.Column<int>(type: "INTEGER", nullable: false),
                    ElementId = table.Column<int>(type: "INTEGER", nullable: false),
                    Placement = table.Column<string>(type: "TEXT", unicode: false, maxLength: 55, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DashboardLinkedElements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dashboards_Info",
                schema: "Dashboard_Tutorial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", unicode: false, maxLength: 255, nullable: false),
                    TemplateId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dashboards_Info", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Elements",
                schema: "Dashboard_Tutorial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Templates",
                schema: "Dashboard_Tutorial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", unicode: false, maxLength: 255, nullable: false),
                    ElementsCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Templates", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DashboardLinkedElements",
                schema: "Dashboard_Tutorial");

            migrationBuilder.DropTable(
                name: "Dashboards_Info",
                schema: "Dashboard_Tutorial");

            migrationBuilder.DropTable(
                name: "Elements",
                schema: "Dashboard_Tutorial");

            migrationBuilder.DropTable(
                name: "Templates",
                schema: "Dashboard_Tutorial");
        }
    }
}
