using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.Net.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MemberShip_PREMIEM",
                columns: table => new
                {
                    MemberShip_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberShip_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MemberShip_Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberShip_PREMIEM", x => x.MemberShip_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberShip_PREMIEM");
        }
    }
}
