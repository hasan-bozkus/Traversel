using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_relation_destination_reservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DestinationID",
                table: "Reservetions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservetions_DestinationID",
                table: "Reservetions",
                column: "DestinationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservetions_Destinations_DestinationID",
                table: "Reservetions",
                column: "DestinationID",
                principalTable: "Destinations",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservetions_Destinations_DestinationID",
                table: "Reservetions");

            migrationBuilder.DropIndex(
                name: "IX_Reservetions_DestinationID",
                table: "Reservetions");

            migrationBuilder.DropColumn(
                name: "DestinationID",
                table: "Reservetions");
        }
    }
}
