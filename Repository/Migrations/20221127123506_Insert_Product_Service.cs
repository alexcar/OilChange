using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class InsertProductService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

              INSERT INTO [dbo].ProductService (ProductiesId,ServicesId) VALUES ('22903817-B2C2-4FFF-A621-1EF70012E4A5', '73FEBEB9-2142-42B1-B919-15E205C425ED')
              INSERT INTO [dbo].ProductService (ProductiesId,ServicesId) VALUES ('5C8A9EA7-E4D2-4911-BFCE-251F71B9A304', '73FEBEB9-2142-42B1-B919-15E205C425ED')
              INSERT INTO [dbo].ProductService (ProductiesId,ServicesId) VALUES ('45317382-8ABD-4D64-B1DA-351E5845C8DF', '73FEBEB9-2142-42B1-B919-15E205C425ED')
              INSERT INTO [dbo].ProductService (ProductiesId,ServicesId) VALUES ('94D2077E-53FC-4365-9D66-4BE3A7290AEA', '73FEBEB9-2142-42B1-B919-15E205C425ED')
              INSERT INTO [dbo].ProductService (ProductiesId,ServicesId) VALUES ('E32AF9F5-64E3-4B3F-86EC-83032E2F61EF', '73FEBEB9-2142-42B1-B919-15E205C425ED')
              INSERT INTO [dbo].ProductService (ProductiesId,ServicesId) VALUES ('7008ADCD-47B1-4500-AEE4-8EFE86AE70DD', '73FEBEB9-2142-42B1-B919-15E205C425ED')
              INSERT INTO [dbo].ProductService (ProductiesId,ServicesId) VALUES ('AC72E496-5474-4413-84C7-A4F65F49AA06', '73FEBEB9-2142-42B1-B919-15E205C425ED')
              INSERT INTO [dbo].ProductService (ProductiesId,ServicesId) VALUES ('DBB32C9E-F6F1-4263-BD4A-A75698DCEF8B', '73FEBEB9-2142-42B1-B919-15E205C425ED')
              INSERT INTO [dbo].ProductService (ProductiesId,ServicesId) VALUES ('000CC4AB-88BE-4E6C-8D6A-AA50427DEC2A', '73FEBEB9-2142-42B1-B919-15E205C425ED')
              INSERT INTO [dbo].ProductService (ProductiesId,ServicesId) VALUES ('83B5E659-3B40-41CF-A865-BBD60C7C2DC6', '73FEBEB9-2142-42B1-B919-15E205C425ED')
              INSERT INTO [dbo].ProductService (ProductiesId,ServicesId) VALUES ('B9D91649-2578-404F-9DBC-F31FD72180FC', '73FEBEB9-2142-42B1-B919-15E205C425ED')
              INSERT INTO [dbo].ProductService (ProductiesId,ServicesId) VALUES ('233F261A-94F5-4B43-944D-FFE5A2D31EFA', '73FEBEB9-2142-42B1-B919-15E205C425ED')

              INSERT INTO [dbo].ProductService (ProductiesId,ServicesId) VALUES ('74B62D4E-10D1-473C-9EFE-721A6EDE75BC', '400CEE89-EE80-4DAD-BA02-081577859F7B')
              INSERT INTO [dbo].ProductService (ProductiesId,ServicesId) VALUES ('984195C1-609F-44E6-BE0B-A8B76DCD1DCB', '4080D299-0EC6-4277-984B-14397C0127A8')
              INSERT INTO [dbo].ProductService (ProductiesId,ServicesId) VALUES ('75007B7A-936F-4E13-904A-CDAB4591FAD0', 'E3BAAA5B-14D6-4FF3-9170-BDB3212BE3BB')
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
