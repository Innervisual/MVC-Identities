using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class Updatee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "90d1a2e3-8e24-466f-9fdd-f8ddbfd7c9e5", "0706934e-8215-4424-8ed9-d17e1f8f88e3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4c6d3734-6cc4-4655-aafa-65652b279c87", "e6edb03f-6f69-4145-b560-358155348e3a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "81f5018b-8d9e-4fcf-ad95-a811b582505e", 0, 640424, "00c96e41-f7a2-4120-82e5-bb104a1257ee", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEM/HxE/gy19wGj/SkLOUfA/+lPW2kBsg9kp6siv0mRVVOOxq/w918jhPOqWZTmO1Lg==", null, false, "ef9eec74-33b0-42da-a0a3-5a68b233a484", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "81f5018b-8d9e-4fcf-ad95-a811b582505e", "90d1a2e3-8e24-466f-9fdd-f8ddbfd7c9e5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c6d3734-6cc4-4655-aafa-65652b279c87");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "81f5018b-8d9e-4fcf-ad95-a811b582505e", "90d1a2e3-8e24-466f-9fdd-f8ddbfd7c9e5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90d1a2e3-8e24-466f-9fdd-f8ddbfd7c9e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81f5018b-8d9e-4fcf-ad95-a811b582505e");

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
    }
}
