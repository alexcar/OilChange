using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class InsertAspNetRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            INSERT INTO [dbo].[AspNetRoles] (Id, Name, NormalizedName) VALUES (NEWID(), 'Customer', 'CUSTOMER')
            INSERT INTO [dbo].[AspNetRoles] (Id, Name, NormalizedName) VALUES (NEWID(), 'Administrator', 'ADMINISTRATOR')
        ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
