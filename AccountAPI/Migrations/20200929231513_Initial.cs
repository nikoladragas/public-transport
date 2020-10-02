﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: false),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Photo = table.Column<string>(nullable: true),
                    UserType = table.Column<int>(nullable: false),
                    UserStatus = table.Column<int>(nullable: false),
                    Role = table.Column<string>(nullable: false, defaultValue: "AppUser")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "LastName", "Name", "PasswordHash", "PasswordSalt", "Photo", "Role", "UserStatus", "UserType" },
                values: new object[] { 1, new DateTime(1990, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", "Doe", "Joe", new byte[] { 103, 104, 119, 130, 109, 217, 189, 27, 40, 202, 196, 226, 174, 38, 158, 249, 44, 124, 108, 167, 134, 17, 236, 80, 84, 135, 37, 195, 155, 132, 235, 222, 70, 168, 154, 245, 43, 76, 124, 60, 147, 209, 34, 124, 96, 145, 141, 40, 39, 245, 152, 168, 121, 23, 96, 143, 61, 153, 247, 177, 211, 19, 60, 176 }, new byte[] { 250, 171, 235, 172, 35, 239, 120, 5, 199, 130, 13, 247, 20, 120, 214, 243, 28, 225, 210, 137, 29, 149, 152, 175, 21, 64, 2, 13, 244, 153, 142, 42, 159, 9, 46, 189, 21, 186, 192, 238, 148, 52, 171, 77, 61, 191, 12, 240, 86, 148, 14, 39, 19, 16, 127, 41, 80, 230, 226, 68, 115, 175, 154, 207, 216, 214, 188, 75, 250, 143, 213, 160, 225, 242, 94, 153, 7, 89, 237, 29, 118, 50, 251, 63, 208, 23, 41, 85, 139, 8, 125, 215, 139, 1, 97, 172, 121, 23, 136, 194, 105, 197, 67, 12, 71, 180, 88, 178, 153, 13, 219, 10, 221, 59, 227, 200, 151, 143, 24, 176, 31, 185, 30, 162, 135, 12, 156, 58 }, null, "Admin", 2, 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "LastName", "Name", "PasswordHash", "PasswordSalt", "Photo", "Role", "UserStatus", "UserType" },
                values: new object[] { 2, new DateTime(1993, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "controller@gmail.com", "Doe", "Jane", new byte[] { 203, 248, 78, 49, 184, 173, 94, 222, 37, 190, 20, 99, 214, 163, 43, 173, 28, 38, 142, 41, 183, 63, 213, 130, 210, 146, 200, 45, 108, 224, 102, 230, 160, 245, 52, 127, 111, 255, 126, 91, 187, 13, 216, 12, 255, 166, 227, 242, 63, 200, 53, 251, 140, 24, 119, 88, 140, 182, 110, 23, 130, 137, 226, 117 }, new byte[] { 174, 12, 58, 172, 34, 9, 222, 198, 126, 179, 80, 248, 132, 161, 12, 71, 153, 33, 58, 20, 71, 153, 28, 189, 119, 152, 5, 23, 231, 0, 181, 70, 98, 0, 56, 74, 13, 236, 239, 155, 34, 246, 196, 97, 23, 198, 79, 104, 200, 32, 25, 117, 76, 253, 172, 93, 247, 155, 128, 77, 251, 32, 180, 85, 12, 196, 145, 41, 223, 29, 136, 224, 238, 79, 37, 167, 11, 8, 217, 30, 213, 98, 252, 147, 11, 125, 190, 25, 183, 171, 125, 114, 128, 145, 78, 253, 243, 187, 109, 80, 61, 85, 126, 104, 194, 199, 184, 41, 219, 168, 135, 215, 244, 110, 205, 35, 77, 76, 232, 195, 188, 33, 174, 79, 132, 107, 214, 106 }, null, "Controller", 2, 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "LastName", "Name", "PasswordHash", "PasswordSalt", "Photo", "Role", "UserStatus", "UserType" },
                values: new object[] { 3, new DateTime(1996, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "appuser@gmail.com", "Doe", "John", new byte[] { 81, 160, 175, 146, 144, 106, 149, 246, 93, 111, 236, 93, 15, 251, 57, 87, 51, 101, 23, 14, 19, 80, 159, 58, 171, 83, 9, 9, 210, 124, 33, 61, 206, 208, 92, 41, 25, 37, 127, 133, 228, 62, 8, 205, 53, 231, 120, 110, 184, 156, 192, 43, 240, 220, 12, 46, 44, 10, 241, 110, 228, 157, 46, 175 }, new byte[] { 111, 133, 148, 74, 110, 193, 234, 159, 10, 13, 60, 92, 35, 159, 200, 131, 32, 111, 118, 24, 24, 200, 49, 229, 51, 147, 105, 98, 220, 248, 40, 189, 108, 196, 0, 123, 70, 117, 249, 49, 221, 136, 2, 132, 165, 146, 14, 184, 178, 85, 11, 17, 45, 29, 52, 158, 120, 128, 101, 203, 5, 4, 13, 188, 220, 31, 15, 246, 245, 222, 198, 37, 155, 13, 142, 48, 119, 182, 57, 153, 40, 237, 145, 63, 20, 113, 56, 33, 27, 217, 153, 31, 58, 63, 122, 125, 187, 197, 165, 209, 71, 70, 106, 244, 104, 43, 12, 135, 105, 49, 211, 162, 168, 180, 223, 33, 8, 223, 172, 217, 192, 130, 254, 200, 200, 100, 33, 31 }, null, "AppUser", 2, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
