using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class InsertCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
               INSERT INTO [dbo].[Company] (Id, Name, CommercialName, Cnpj, Contact, Ddd, Phone, WebSite, Email, Address, Neighborhood, County, Country, 
              UF, ZipCode, PerfilId) VALUES (newid(), 'Troca Óleo Ltda', 'Troca Óleo Ltda', '68.975.735/0001-74', 'José da Silva', '11', '46561000',
              'www.trocaoleo.com', 'fale@trocaoleo.com', 'Rua A, 100', 'Centro', 'Santa Isabel', 'Brasil', 'SP', '07500000', 'A1345629-9283-45E4-B398-D1EB0072EAD8') 
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
