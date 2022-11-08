using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvancedWebAPIProject.Migrations
{
    public partial class ownernamea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.AddColumn<string>(
                name: "Ownername",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ownername",
                table: "Companies");

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "Country", "Name" },
                values: new object[,]
                {
                    { 7, "Generic Address", "We Dont know", "Generic IT Company" },
                    { 8, "Generic Address", "We Dont know", "Generic IT Company" },
                    { 9, "Generic Address", "We Dont know", "Generic IT Company" },
                    { 10, "Generic Address", "We Dont know", "Generic IT Company" },
                    { 11, "Generic Address", "We Dont know", "Generic IT Company" },
                    { 12, "Generic Address", "We Dont know", "Generic IT Company" },
                    { 13, "Generic Address", "We Dont know", "Generic IT Company" },
                    { 14, "Generic Address", "We Dont know", "Generic IT Company" },
                    { 15, "Generic Address", "We Dont know", "Generic IT Company" },
                    { 16, "Generic Address", "We Dont know", "Generic IT Company" },
                    { 17, "Generic Address", "We Dont know", "Generic IT Company" },
                    { 18, "Generic Address", "We Dont know", "Generic IT Company" },
                    { 19, "Generic Address", "We Dont know", "Generic IT Company" },
                    { 20, "Generic Address", "We Dont know", "Generic IT Company" }
                });
        }
    }
}
