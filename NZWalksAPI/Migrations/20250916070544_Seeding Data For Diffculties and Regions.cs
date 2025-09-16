using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalksAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataForDiffcultiesandRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1f34fc24-2aef-4806-8d29-7d3d2725b1a1"), "Hard" },
                    { new Guid("e80644be-ff45-4735-a7db-a9d42bb0974c"), "Easy" },
                    { new Guid("f3c86ae4-e7af-4a81-85f8-6b8fc9437e4b"), "Medium" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("05842e4d-59b0-4fb1-8ac7-cf5018f60d39"), "New", "NNeeww", "https://example.com/images/auckland.jpg" },
                    { new Guid("453733fc-3190-4b41-88fe-17fba54de503"), "N", "NN", "https://example.com/images/auckland.jpg" },
                    { new Guid("5ffa4e22-d1c0-470b-8a9c-8f04b27d3093"), "AKL", "Auckland", "https://example.com/images/auckland.jpg" },
                    { new Guid("c20f936e-5de1-434c-a2be-97ad2fd03867"), "Ne", "NNee", "https://example.com/images/auckland.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("1f34fc24-2aef-4806-8d29-7d3d2725b1a1"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("e80644be-ff45-4735-a7db-a9d42bb0974c"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("f3c86ae4-e7af-4a81-85f8-6b8fc9437e4b"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("05842e4d-59b0-4fb1-8ac7-cf5018f60d39"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("453733fc-3190-4b41-88fe-17fba54de503"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("5ffa4e22-d1c0-470b-8a9c-8f04b27d3093"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c20f936e-5de1-434c-a2be-97ad2fd03867"));
        }
    }
}
