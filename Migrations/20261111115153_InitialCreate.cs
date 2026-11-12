using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET_CORE_MVC.Migrations;

/// <inheritdoc />
public partial class _20261111115153_InitialCreate : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Employees",
            columns: table => new
            {
                EmployeeId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Position = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Employees", x => x.EmployeeId);
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Employees");
    }
}
