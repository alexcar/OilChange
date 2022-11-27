using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableServiceAndInsertdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Service",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.Sql(@"
                INSERT INTO [dbo].[VehicleBrand] (Id, Name) VALUES (newid(), 'Fiat');
                INSERT INTO [dbo].[VehicleBrand] (Id, Name) VALUES (newid(), 'Ford');
                INSERT INTO [dbo].[VehicleBrand] (Id, Name) VALUES (newid(), 'VW');
                INSERT INTO [dbo].[VehicleBrand] (Id, Name) VALUES (newid(), 'Ka');
                INSERT INTO [dbo].[VehicleModel] (Id, Name) VALUES (newid(), 'Amarok');
                INSERT INTO [dbo].[VehicleModel] (Id, Name) VALUES (newid(), 'Toro');
                INSERT INTO [dbo].[VehicleYear] (Id, Name) VALUES (newid(), '2020');
                INSERT INTO [dbo].[VehicleModel] (Id, Name) VALUES (newid(), '2021');
                INSERT INTO [dbo].[VehicleModel] (Id, Name) VALUES (newid(), '2022');
                INSERT INTO [dbo].[VehicleFuel] (Id, Name) VALUES (newid(), 'Álcool');
                INSERT INTO [dbo].[VehicleFuel] (Id, Name) VALUES (newid(), 'Diesel');
                INSERT INTO [dbo].[VehicleFuel] (Id, Name) VALUES (newid(), 'Flex');
                INSERT INTO [dbo].[VehicleFuel] (Id, Name) VALUES (newid(), 'Gasolina');
                INSERT INTO [dbo].[Infrastructure] (Id, Name) VALUES (newid(), 'Ar-condicionado');
                INSERT INTO [dbo].[Infrastructure] (Id, Name) VALUES (newid(), 'Café');
                INSERT INTO [dbo].[Infrastructure] (Id, Name) VALUES (newid(), 'TV');
                INSERT INTO [dbo].[Infrastructure] (Id, Name) VALUES (newid(), 'Internet');
                INSERT INTO [dbo].[Perfil] (Id, Name) VALUES (newid(), 'Customer');
                INSERT INTO [dbo].[Perfil] (Id, Name) VALUES (newid(), 'Administrator');
                INSERT INTO [dbo].[Service] (Id, Name) VALUES (newid(), 'Troca de óleo');
                INSERT INTO [dbo].[Service] (Id, Name) VALUES (newid(), 'Troca de filtro de ar');
                INSERT INTO [dbo].[Service] (Id, Name) VALUES (newid(), 'Troca de filtro de combustível');
                INSERT INTO [dbo].[Service] (Id, Name) VALUES (newid(), 'Troca de Filtro do ar-condicionado');
                INSERT INTO [dbo].[ProductManufacturer] (Id, Name) VALUES (newid(), 'Lubrax');
                INSERT INTO [dbo].[ProductManufacturer] (Id, Name) VALUES (newid(), 'Petronas');
                INSERT INTO [dbo].[ProductManufacturer] (Id, Name) VALUES (newid(), 'Mobil');
                INSERT INTO [dbo].[ProductManufacturer] (Id, Name) VALUES (newid(), 'Castrol');
                INSERT INTO [dbo].[PriceQuoteAction] (Id, Name) VALUES (newid(), 'Realizar Check-in');
                INSERT INTO [dbo].[PriceQuoteAction] (Id, Name) VALUES (newid(), 'Realizar Check-out');
                INSERT INTO [dbo].[PriceQuoteAction] (Id, Name) VALUES (newid(), 'Cancelar');
                INSERT INTO [dbo].[ReasonCancellationPriceQuote] (Id, Name) VALUES (newid(), 'Cancelado pelo cliente');
                INSERT INTO [dbo].[ReasonCancellationPriceQuote] (Id, Name) VALUES (newid(), 'Cancelado pela empresa');
                INSERT INTO [dbo].[PriceQuoteStatus] (Id, Name) VALUES (newid(), 'Enviado');
                INSERT INTO [dbo].[PriceQuoteStatus] (Id, Name) VALUES (newid(), 'Respondido');
                INSERT INTO [dbo].[PriceQuoteStatus] (Id, Name) VALUES (newid(), 'Agendado');
                INSERT INTO [dbo].[PriceQuoteStatus] (Id, Name) VALUES (newid(), 'Executando');
                INSERT INTO [dbo].[PriceQuoteStatus] (Id, Name) VALUES (newid(), 'Fechado');
                INSERT INTO [dbo].[PriceQuoteStatus] (Id, Name) VALUES (newid(), 'Cancelado');            
                INSERT INTO [dbo].[PaymentMethod] (Id, Name, ValueDiscount) VALUES (newid(), 'Dinheiro', 3.99);
                INSERT INTO [dbo].[PaymentMethod] (Id, Name, ValueDiscount) VALUES (newid(), 'Boleto', 1.99);
                INSERT INTO [dbo].[PaymentMethod] (Id, Name, ValueDiscount) VALUES (newid(), 'PIX', 1.99);
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Service",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);
        }
    }
}
