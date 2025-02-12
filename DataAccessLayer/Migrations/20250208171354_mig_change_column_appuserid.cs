using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_change_column_appuserid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_AppUserId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "Comments",
                newName: "AppUserID");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_AppUserId",
                table: "Comments",
                newName: "IX_Comments_AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_AppUserID",
                table: "Comments",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_AppUserID",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "AppUserID",
                table: "Comments",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_AppUserID",
                table: "Comments",
                newName: "IX_Comments_AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_AppUserId",
                table: "Comments",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
