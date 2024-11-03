﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManageEmployee.Dal.Migrations;

public partial class initial55 : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "MenuRoles",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                MenuId = table.Column<int>(type: "int", nullable: true),
                UserRoleId = table.Column<int>(type: "int", nullable: true),
                Add = table.Column<bool>(type: "bit", nullable: false),
                Edit = table.Column<bool>(type: "bit", nullable: false),
                Delete = table.Column<bool>(type: "bit", nullable: false),
                View = table.Column<bool>(type: "bit", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_MenuRoles", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Menus",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Code = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                CodeParent = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                Note = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Menus", x => x.Id);
            });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "MenuRoles");

        migrationBuilder.DropTable(
            name: "Menus");
    }
}
