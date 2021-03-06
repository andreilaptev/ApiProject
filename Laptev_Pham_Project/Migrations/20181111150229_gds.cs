﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Laptev_Pham_Project.Migrations
{
    public partial class gds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ArrivalTime",
                table: "Flight",
                nullable: false,
                oldClrType: typeof(DateTimeOffset));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ArrivalTime",
                table: "Flight",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
