using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class AlterSequencePriceQuoteStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
              UPDATE [dbo].PriceQuoteStatus SET Sequence = 1 WHERE Id = '03DB62D0-7388-4821-8F2D-283F8DAD7DC4'
              UPDATE [dbo].PriceQuoteStatus SET Sequence = 2 WHERE Id = '3DCE0271-DEEC-4156-AAF5-0D91FA9394E0'
              UPDATE [dbo].PriceQuoteStatus SET Sequence = 3 WHERE Id = '06B969F1-D041-4F72-B484-B181DE88C80C'
              UPDATE [dbo].PriceQuoteStatus SET Sequence = 4 WHERE Id = 'E2E347B6-B032-4FD3-BB93-AC27C09A172B'
              UPDATE [dbo].PriceQuoteStatus SET Sequence = 5 WHERE Id = 'A12E4266-AEE0-423D-8F0C-71C4CBAEB1EF'
              UPDATE [dbo].PriceQuoteStatus SET Sequence = 6 WHERE Id = 'F4746874-4FEA-4AB2-B4AB-B3E69CD0C2B7'
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
