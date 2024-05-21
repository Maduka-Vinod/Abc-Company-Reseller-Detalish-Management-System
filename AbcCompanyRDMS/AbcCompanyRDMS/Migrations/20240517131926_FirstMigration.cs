using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbcCompanyRDMS.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resellers",
                columns: table => new
                {
                    ResellerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResellerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResellerAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResellerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResellerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResellerContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResellerContactPersonPhone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resellers", x => x.ResellerId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resellers");
        }
    }
}
