using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.Net.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MemberShip",
                columns: table => new
                {
                    Member_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Member_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Member_Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Member_Type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Member_Phone = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Member_Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Member_Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Member_Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberShip", x => x.Member_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberShip");
        }
    }
}
