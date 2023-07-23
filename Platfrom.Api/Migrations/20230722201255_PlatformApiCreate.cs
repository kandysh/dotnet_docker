using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Platfrom.Api.Migrations
{
    /// <inheritdoc />
    public partial class PlatformApiCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlatformTbl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlatformName = table.Column<string>(type: "nvarchar", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar", nullable: false),
                    Cost = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 7, 22, 20, 12, 55, 235, DateTimeKind.Utc).AddTicks(5782)),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 7, 22, 20, 12, 55, 235, DateTimeKind.Utc).AddTicks(6088))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlatformTbl", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlatformTbl");
        }
    }
}
