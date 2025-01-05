using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_CodeFirst_2.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Taxs_Customers_CustomerId",
                table: "Taxs");

            migrationBuilder.DropIndex(
                name: "IX_Taxs_CustomerId",
                table: "Taxs");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TaxId",
                table: "Customers",
                column: "TaxId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Taxs_TaxId",
                table: "Customers",
                column: "TaxId",
                principalTable: "Taxs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Taxs_TaxId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_TaxId",
                table: "Customers");

            migrationBuilder.CreateIndex(
                name: "IX_Taxs_CustomerId",
                table: "Taxs",
                column: "CustomerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Taxs_Customers_CustomerId",
                table: "Taxs",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
