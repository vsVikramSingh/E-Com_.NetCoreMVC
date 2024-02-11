using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_ComWeb.Migrations
{
    /// <inheritdoc />
    public partial class addForeignKeyCompanyToUserRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CampanyId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CampanyId",
                table: "AspNetUsers",
                column: "CampanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Companies_CampanyId",
                table: "AspNetUsers",
                column: "CampanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Companies_CampanyId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CampanyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CampanyId",
                table: "AspNetUsers");
        }
    }
}
