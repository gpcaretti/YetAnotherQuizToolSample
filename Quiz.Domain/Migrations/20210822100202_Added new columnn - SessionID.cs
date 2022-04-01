﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace PatenteN.Quiz.Domain.Migrations
{
    public partial class AddednewcolumnnSessionID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SessionID",
                table: "Result",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SessionID",
                table: "Result");
        }
    }
}
