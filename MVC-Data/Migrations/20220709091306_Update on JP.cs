using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class UpdateonJP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "165b5216-b485-4f35-9c0f-105c76a86dff");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bf34bb20-871b-404a-9f28-8128765f3129", "f34ee858-8c30-45fd-8cb0-82db365142e9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f34ee858-8c30-45fd-8cb0-82db365142e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf34bb20-871b-404a-9f28-8128765f3129");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "334a50e1-b42f-45a0-b04b-096d972a22fb", "b0ba71ee-cc87-4409-941c-34de376f8976", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "69032e8c-4c73-4dc5-a74b-2ac5131270e4", "e89498b7-bdba-41e3-be21-ac1744e37c32", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2a771d01-a2be-4c25-8880-1e4846b24c60", 0, 640424, "b991d6f3-1c22-4b2f-9353-9528a7d260c4", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEHnD0Xb9Mxhcpw3VwRI1oDTap2+X0mITMSBxqUd+RArKcz14sWq1/GJanB7QVBQOQQ==", null, false, "acb04388-20e5-4a15-b2ef-4ba0bb21bc04", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "2a771d01-a2be-4c25-8880-1e4846b24c60", "334a50e1-b42f-45a0-b04b-096d972a22fb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69032e8c-4c73-4dc5-a74b-2ac5131270e4");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2a771d01-a2be-4c25-8880-1e4846b24c60", "334a50e1-b42f-45a0-b04b-096d972a22fb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "334a50e1-b42f-45a0-b04b-096d972a22fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a771d01-a2be-4c25-8880-1e4846b24c60");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f34ee858-8c30-45fd-8cb0-82db365142e9", "56258178-3c7f-48b8-8689-2fec2edb0efd", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "165b5216-b485-4f35-9c0f-105c76a86dff", "3b432b69-eba5-482a-a146-3e207e81ff50", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bf34bb20-871b-404a-9f28-8128765f3129", 0, 640424, "096a8233-834d-4f1b-871c-ab9cb229806e", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEJSqU4M2jbaoV23d9fBSq7T7ADNZ2XN7aYoIZzNO4UJLK9Lur02coVacCQox87xI1A==", null, false, "51a875d8-2fa1-4e85-9163-a731816b4574", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "bf34bb20-871b-404a-9f28-8128765f3129", "f34ee858-8c30-45fd-8cb0-82db365142e9" });
        }
    }
}
