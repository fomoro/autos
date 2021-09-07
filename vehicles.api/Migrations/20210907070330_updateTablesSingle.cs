using Microsoft.EntityFrameworkCore.Migrations;

namespace vehicles.api.Migrations
{
    public partial class updateTablesSingle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_vehicleTypes",
                table: "vehicleTypes");

            migrationBuilder.RenameTable(
                name: "vehicleTypes",
                newName: "VehicleTypes");

            migrationBuilder.RenameIndex(
                name: "IX_vehicleTypes_Description",
                table: "VehicleTypes",
                newName: "IX_VehicleTypes_Description");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleTypes",
                table: "VehicleTypes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Brands_Description",
                table: "Brands",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DocumentTypes_Description",
                table: "DocumentTypes",
                column: "Description",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleTypes",
                table: "VehicleTypes");

            migrationBuilder.RenameTable(
                name: "VehicleTypes",
                newName: "vehicleTypes");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleTypes_Description",
                table: "vehicleTypes",
                newName: "IX_vehicleTypes_Description");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vehicleTypes",
                table: "vehicleTypes",
                column: "Id");
        }
    }
}
