using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class AlterSequencePriceQuoteAction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
              UPDATE [dbo].PriceQuoteAction SET Sequence = 1 WHERE Id = 'E9895233-338B-4197-90FA-562740273B23'
              UPDATE [dbo].PriceQuoteAction SET Sequence = 2 WHERE Id = 'D43D7153-1139-4FEE-8D30-D94395BACB8B'
              UPDATE [dbo].PriceQuoteAction SET Sequence = 3 WHERE Id = '3F15CD8C-9B59-4F97-A60C-3360AF742882'
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
