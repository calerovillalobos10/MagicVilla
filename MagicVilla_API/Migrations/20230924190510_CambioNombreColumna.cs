using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class CambioNombreColumna : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Trifa",
                table: "Villas",
                newName: "Tarifa");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 9, 24, 13, 5, 10, 601, DateTimeKind.Local).AddTicks(6274), new DateTime(2023, 9, 24, 13, 5, 10, 601, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 9, 24, 13, 5, 10, 601, DateTimeKind.Local).AddTicks(6335), new DateTime(2023, 9, 24, 13, 5, 10, 601, DateTimeKind.Local).AddTicks(6334) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tarifa",
                table: "Villas",
                newName: "Trifa");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 9, 24, 12, 38, 37, 333, DateTimeKind.Local).AddTicks(5080), new DateTime(2023, 9, 24, 12, 38, 37, 333, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 9, 24, 12, 38, 37, 333, DateTimeKind.Local).AddTicks(5084), new DateTime(2023, 9, 24, 12, 38, 37, 333, DateTimeKind.Local).AddTicks(5083) });
        }
    }
}
