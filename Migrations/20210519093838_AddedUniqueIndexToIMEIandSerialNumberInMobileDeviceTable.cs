using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileDevicesManagement.Migrations
{
    public partial class AddedUniqueIndexToIMEIandSerialNumberInMobileDeviceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_MobileDevices_IMEI",
                table: "MobileDevices",
                column: "IMEI",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MobileDevices_SerialNumber",
                table: "MobileDevices",
                column: "SerialNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MobileDevices_IMEI",
                table: "MobileDevices");

            migrationBuilder.DropIndex(
                name: "IX_MobileDevices_SerialNumber",
                table: "MobileDevices");
        }
    }
}
