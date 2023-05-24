using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorIMS.Migrations
{
    public partial class nocheckoutrequests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckoutRequests");

            migrationBuilder.DropTable(
                name: "Checkouts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CheckoutRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    InventoryId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckoutRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckoutRequests_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CheckoutRequests_AspNetUsers_LastModifiedById",
                        column: x => x.LastModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CheckoutRequests_Inventories_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Checkouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckedOutById = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    InventoryId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Checkouts_AspNetUsers_CheckedOutById",
                        column: x => x.CheckedOutById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checkouts_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Checkouts_AspNetUsers_LastModifiedById",
                        column: x => x.LastModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Checkouts_Inventories_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckoutRequests_CreatedById",
                table: "CheckoutRequests",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CheckoutRequests_InventoryId",
                table: "CheckoutRequests",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckoutRequests_LastModifiedById",
                table: "CheckoutRequests",
                column: "LastModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_CheckedOutById",
                table: "Checkouts",
                column: "CheckedOutById");

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_CreatedById",
                table: "Checkouts",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_InventoryId",
                table: "Checkouts",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_LastModifiedById",
                table: "Checkouts",
                column: "LastModifiedById");
        }
    }
}
