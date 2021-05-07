﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class AddedVideoStock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "Videos",
                newName: "RentedOut");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Rentals",
                newName: "RentDate");

            migrationBuilder.AddColumn<int>(
                name: "InStock",
                table: "Videos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InStock",
                table: "Videos");

            migrationBuilder.RenameColumn(
                name: "RentedOut",
                table: "Videos",
                newName: "Stock");

            migrationBuilder.RenameColumn(
                name: "RentDate",
                table: "Rentals",
                newName: "StartDate");
        }
    }
}
