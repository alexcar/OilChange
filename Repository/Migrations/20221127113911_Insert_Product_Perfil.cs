using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class InsertProductPerfil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

            INSERT INTO [dbo].[Perfil] (Id, Name) VALUES (newid(), 'Company');

            INSERT INTO [dbo].[Product] (Id, Name, Description, Price, ProductManufacturerId) 
            VALUES (newid(), 'Óleo Sintetico Selenia F 5w30 Petronas Lt', 'Óleo Sintetico Selenia Perform F 5w30 lt - Petronas', 45.65, 'C7B4CAD0-FA02-4163-9023-1808D60611C8')
            INSERT INTO [dbo].[Product] (Id, Name, Description, Price, ProductManufacturerId) 
            VALUES (newid(), 'Óleo Mineral 25w60 Petronas Sl Lt', 'Óleo Mineral 25w60 Petronas Syntium 300 Api Sl Lt', 31.85, 'C7B4CAD0-FA02-4163-9023-1808D60611C8')
            INSERT INTO [dbo].[Product] (Id, Name, Description, Price, ProductManufacturerId) 
            VALUES (newid(), 'Óleo Sintético Ow20 Syntium 7000 Hybrid 1 Litro Petronas', 'Óleo Sintético Ow20 Syntium 7000 Hybrid 1 Litro Petronas', 49.04, 'C7B4CAD0-FA02-4163-9023-1808D60611C8')

            INSERT INTO [dbo].[Product] (Id, Name, Description, Price, ProductManufacturerId) 
            VALUES (newid(), 'Óleo Lubrificante Mobil Super Sintético 5w30 Sp 1l', 'Óleo Lubrificante Mobil Super Sintético 5w30 Sp 1l', 38.99, '3B82F0B4-42A2-4A79-B0E4-52FAD2649554')
            INSERT INTO [dbo].[Product] (Id, Name, Description, Price, ProductManufacturerId) 
            VALUES (newid(), 'Óleo Automotivo Mobil Super 20w50 1 Litro', 'Óleo Automotivo Mobil Super 20w50 1 Litro', 53.99, '3B82F0B4-42A2-4A79-B0E4-52FAD2649554')
            INSERT INTO [dbo].[Product] (Id, Name, Description, Price, ProductManufacturerId) 
            VALUES (newid(), 'Óleo Automotivo Mobil Super 30w50 1 Litro', 'Óleo Automotivo Mobil Super 30w50 1 Litro', 82.99, '3B82F0B4-42A2-4A79-B0E4-52FAD2649554')

            INSERT INTO [dbo].[Product] (Id, Name, Description, Price, ProductManufacturerId) 
            VALUES (newid(), 'Óleo Lubrificante Castrol 20w50 Mineral Sl 1Lt', 'Óleo Lubrificante Castrol Gtx Anti-Borra 20w50 Mineral 1 Toyota Api Sl Litro', 38.99, '237EE460-A072-4AB6-B6AA-BFAF7043969E')
            INSERT INTO [dbo].[Product] (Id, Name, Description, Price, ProductManufacturerId) 
            VALUES (newid(), 'Óleo Motor Castrol Gtx Ultraclean Sintético 5w30 Sn', 'Óleo Motor Castrol Gtx Ultraclean Sintético 5w30 Sn', 65.78, '237EE460-A072-4AB6-B6AA-BFAF7043969E')
            INSERT INTO [dbo].[Product] (Id, Name, Description, Price, ProductManufacturerId) 
            VALUES (newid(), 'Óleo Castrol Magnatec 5w40 Oleo De Motor Sintético 1lt', 'Oleo Castrol Magnatec 5w40 Oleo De Motor Sintético 1lt', 59.89, '237EE460-A072-4AB6-B6AA-BFAF7043969E')

            INSERT INTO [dbo].[Product] (Id, Name, Description, Price, ProductManufacturerId) 
            VALUES (newid(), 'Óleo Petronas Selenia Perform 5w30 Sintético 1lt', 'Óleo Petronas Selenia Perform 5w30 Sintético 1lt', 49.90, '210ABD4D-79AE-4D84-BD9F-C5733C076D45')
            INSERT INTO [dbo].[Product] (Id, Name, Description, Price, ProductManufacturerId) 
            VALUES (newid(), 'Óleo Petronas Selenia Perform 10w40 Sintético 2lt', 'Óleo Petronas Selenia Perform 5w30 Sintético 1lt', 99.80, '210ABD4D-79AE-4D84-BD9F-C5733C076D45')
            INSERT INTO [dbo].[Product] (Id, Name, Description, Price, ProductManufacturerId) 
            VALUES (newid(), 'Óleo Petronas Selenia Perform 15w40 Sintético 1lt', 'Óleo Petronas Selenia Perform 5w30 Sintético 1lt', 49.99, '210ABD4D-79AE-4D84-BD9F-C5733C076D45')            
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
