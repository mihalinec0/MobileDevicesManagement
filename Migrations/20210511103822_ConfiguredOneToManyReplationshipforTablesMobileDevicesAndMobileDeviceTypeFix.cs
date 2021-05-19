using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileDevicesManagement.Migrations
{
    public partial class ConfiguredOneToManyReplationshipforTablesMobileDevicesAndMobileDeviceTypeFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MobileDevices_MobileDeviceType_TypeId",
                table: "MobileDevices");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "MobileDevices",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MobileDevices_MobileDeviceType_TypeId",
                table: "MobileDevices",
                column: "TypeId",
                principalTable: "MobileDeviceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MobileDevices_MobileDeviceType_TypeId",
                table: "MobileDevices");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "MobileDevices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_MobileDevices_MobileDeviceType_TypeId",
                table: "MobileDevices",
                column: "TypeId",
                principalTable: "MobileDeviceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
