using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ArticoliGratis.Migrations
{
    public partial class EliminoDataDiNascita : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataDiNascita",
                table: "DatiAnagraficiUtenti");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataDiNascita",
                table: "DatiAnagraficiUtenti",
                nullable: true);
        }
    }
}
