using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileDevicesManagement.Migrations
{
    public partial class ConfiguredOneToManyReplationshipforTablesMobileDevicesAndMobileDeviceType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "MobileDevices",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MobileDevices_TypeId",
                table: "MobileDevices",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MobileDevices_MobileDeviceType_TypeId",
                table: "MobileDevices",
                column: "TypeId",
                principalTable: "MobileDeviceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MobileDevices_MobileDeviceType_TypeId",
                table: "MobileDevices");

            migrationBuilder.DropIndex(
                name: "IX_MobileDevices_TypeId",
                table: "MobileDevices");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "MobileDevices");
        }
    }
}
