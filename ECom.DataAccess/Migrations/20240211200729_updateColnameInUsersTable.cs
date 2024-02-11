using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_ComWeb.Migrations
{
    /// <inheritdoc />
    public partial class updateColnameInUsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Companies_CampanyId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "CampanyId",
                table: "AspNetUsers",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_CampanyId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "AspNetUsers",
                newName: "CampanyId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_CampanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Companies_CampanyId",
                table: "AspNetUsers",
                column: "CampanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId");
        }
    }
}
