using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class InsertProductUpdateService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

            UPDATE [dbo].Service SET Name = 'Troca de filtro de ar do motor' WHERE Id = '400CEE89-EE80-4DAD-BA02-081577859F7B'
            INSERT INTO [dbo].[Product] (Id, Name, Description, Price, ProductManufacturerId) 
            VALUES (NEWID(), 'Filtro de Ar do Motor - Wega', 'Filtro de Ar do Motor - Wega', 25.61, 'CECF6123-6D41-4F14-A7C4-6DF828D42925')
            INSERT INTO [dbo].[Product] (Id, Name, Description, Price, ProductManufacturerId) 
            VALUES (NEWID(), 'Filtro De Cabine Ar Condicionado - Tecfil', 'Filtro De Cabine Ar Condicionado - Tecfil', 39.59, '33C96D7E-9990-4702-B76F-DF5F15B86822')
            INSERT INTO [dbo].[Product] (Id, Name, Description, Price, ProductManufacturerId) 
            VALUES (NEWID(), 'Filtro Combustível - Mann Wk58', 'Filtro Combustível - Mann Wk58', 17.59, '57473CED-35F3-4125-9E94-F10B3572FE91')
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
