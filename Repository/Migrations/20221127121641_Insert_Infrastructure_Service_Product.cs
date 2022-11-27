using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class InsertInfrastructureServiceProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

            INSERT INTO [dbo].InfrastructureCompany (CompaniesId, InfrastructuresId) VALUES ('9A10D5DF-3C90-446F-9411-625ED909BFC4', '504E5C9C-6412-430B-BDD9-83D84966F01D')
            INSERT INTO [dbo].InfrastructureCompany (CompaniesId, InfrastructuresId) VALUES ('9A10D5DF-3C90-446F-9411-625ED909BFC4', '95366DA9-0CD2-4F8F-9750-93014681F68A')
            INSERT INTO [dbo].InfrastructureCompany (CompaniesId, InfrastructuresId) VALUES ('9A10D5DF-3C90-446F-9411-625ED909BFC4', 'B06C65AD-364E-4C9C-9DAC-C63793841943')
            INSERT INTO [dbo].InfrastructureCompany (CompaniesId, InfrastructuresId) VALUES ('9A10D5DF-3C90-446F-9411-625ED909BFC4', '5F539128-85D7-4674-82BC-E2C755FADAB3')

            INSERT INTO [dbo].CompanyService (CompaniesId, ServicesId) VALUES ('9A10D5DF-3C90-446F-9411-625ED909BFC4', '400CEE89-EE80-4DAD-BA02-081577859F7B')
            INSERT INTO [dbo].CompanyService (CompaniesId, ServicesId) VALUES ('9A10D5DF-3C90-446F-9411-625ED909BFC4', '4080D299-0EC6-4277-984B-14397C0127A8')
            INSERT INTO [dbo].CompanyService (CompaniesId, ServicesId) VALUES ('9A10D5DF-3C90-446F-9411-625ED909BFC4', '73FEBEB9-2142-42B1-B919-15E205C425ED')
            INSERT INTO [dbo].CompanyService (CompaniesId, ServicesId) VALUES ('9A10D5DF-3C90-446F-9411-625ED909BFC4', 'E3BAAA5B-14D6-4FF3-9170-BDB3212BE3BB')

            UPDATE [dbo].Product SET Name = 'Troca de filtro de ar do motor' WHERE Id = '400CEE89-EE80-4DAD-BA02-081577859F7B'
    
            INSERT INTO [dbo].ProductManufacturer (Id, Name) VALUES (NEWID(), 'Wega')
            INSERT INTO [dbo].ProductManufacturer (Id, Name) VALUES (NEWID(), 'Tecfil')
            INSERT INTO [dbo].ProductManufacturer (Id, Name) VALUES (NEWID(), 'Mann Filter')
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
