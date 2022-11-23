using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class InsertRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO [dbo].[AspNetRoles] ([Id],[Name],[NormalizedName],[ConcurrencyStamp]) VALUES ('3d73685d-cd2c-4df3-8550-098d1027760e', 'Customer', 'CUSTOMER', 'f071083f-61d9-42f5-9bad-c9e033c52641');
                INSERT INTO [dbo].[AspNetRoles] ([Id],[Name],[NormalizedName],[ConcurrencyStamp]) VALUES ('87e8836d-9d2a-4020-926c-0b8d72b7e35f', 'Administrator', 'ADMINISTRATOR', 'e15779f4-42bd-4ab2-80e7-bdce38871c20');
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
