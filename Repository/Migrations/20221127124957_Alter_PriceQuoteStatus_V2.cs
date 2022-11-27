using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class AlterPriceQuoteStatusV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "PriceQuoteStatus");

            migrationBuilder.AddColumn<short>(
                name: "Sequence",
                table: "PriceQuoteStatus",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sequence",
                table: "PriceQuoteStatus");

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "PriceQuoteStatus",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
