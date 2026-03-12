using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Members_Id",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "Members",
                newName: "Gender");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Users_Id",
                table: "Members",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Users_Id",
                table: "Members");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Members",
                newName: "gender");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Members_Id",
                table: "Users",
                column: "Id",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
