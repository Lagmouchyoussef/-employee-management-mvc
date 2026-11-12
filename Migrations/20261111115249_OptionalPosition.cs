using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET_CORE_MVC.Migrations;

/// <inheritdoc />
public partial class _20261111115249_OptionalPosition : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AlterColumn<string>(
            name: "Position",
            table: "Employees",
            type: "nvarchar(255)",
            maxLength: 255,
            nullable: true,
            oldClrType: typeof(string),
            oldType: "nvarchar(255)",
            oldMaxLength: 255);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AlterColumn<string>(
            name: "Position",
            table: "Employees",
            type: "nvarchar(255)",
            maxLength: 255,
            nullable: false,
            defaultValue: "",
            oldClrType: typeof(string),
            oldType: "nvarchar(255)",
            oldMaxLength: 255,
            oldNullable: true);
    }
}
