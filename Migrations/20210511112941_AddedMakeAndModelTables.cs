using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileDevicesManagement.Migrations
{
    public partial class AddedMakeAndModelTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Model",
                table: "MobileDevices");

            migrationBuilder.AddColumn<int>(
                name: "MakeId",
                table: "MobileDevices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "MobileDevices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MobileDeviceMake",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileDeviceMake", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileDeviceModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileDeviceModel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MobileDevices_MakeId",
                table: "MobileDevices",
                column: "MakeId");

            migrationBuilder.CreateIndex(
                name: "IX_MobileDevices_ModelId",
                table: "MobileDevices",
                column: "ModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_MobileDevices_MobileDeviceMake_MakeId",
                table: "MobileDevices",
                column: "MakeId",
                principalTable: "MobileDeviceMake",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MobileDevices_MobileDeviceModel_ModelId",
                table: "MobileDevices",
                column: "ModelId",
                principalTable: "MobileDeviceModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MobileDevices_MobileDeviceMake_MakeId",
                table: "MobileDevices");

            migrationBuilder.DropForeignKey(
                name: "FK_MobileDevices_MobileDeviceModel_ModelId",
                table: "MobileDevices");

            migrationBuilder.DropTable(
                name: "MobileDeviceMake");

            migrationBuilder.DropTable(
                name: "MobileDeviceModel");

            migrationBuilder.DropIndex(
                name: "IX_MobileDevices_MakeId",
                table: "MobileDevices");

            migrationBuilder.DropIndex(
                name: "IX_MobileDevices_ModelId",
                table: "MobileDevices");

            migrationBuilder.DropColumn(
                name: "MakeId",
                table: "MobileDevices");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "MobileDevices");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "MobileDevices",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
