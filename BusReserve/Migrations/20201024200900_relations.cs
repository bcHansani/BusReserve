using Microsoft.EntityFrameworkCore.Migrations;

namespace BusReserve.Migrations
{
    public partial class relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BusId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RouteId",
                table: "Buses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_BusId",
                table: "Users",
                column: "BusId");

            migrationBuilder.CreateIndex(
                name: "IX_Buses_RouteId",
                table: "Buses",
                column: "RouteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Buses_BusRoutes_RouteId",
                table: "Buses",
                column: "RouteId",
                principalTable: "BusRoutes",
                principalColumn: "RouteId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Buses_BusId",
                table: "Users",
                column: "BusId",
                principalTable: "Buses",
                principalColumn: "BusId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buses_BusRoutes_RouteId",
                table: "Buses");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Buses_BusId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_BusId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Buses_RouteId",
                table: "Buses");

            migrationBuilder.DropColumn(
                name: "BusId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RouteId",
                table: "Buses");
        }
    }
}
