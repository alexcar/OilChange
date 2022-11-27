using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class Updatetables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
              DELETE [dbo].[VehicleBrand] WHERE Id = 'F4D9C19B-E5DE-4779-BAA5-C163181D0813';  
              UPDATE [dbo].[VehicleModel] SET Name = 'KA' WHERE Id = '510A58AD-125E-4C05-AAD3-4CFF1912915C';
              DELETE [dbo].[VehicleModel] WHERE Id = 'ED8E73F5-3EB9-4499-B215-5F4AD38D6C6A';
              INSERT INTO [dbo].[VehicleYear] (Id, Name) VALUES (NEWID(), '2021')	
              INSERT INTO [dbo].[VehicleYear] (Id, Name) VALUES (NEWID(), '2022')	

            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
