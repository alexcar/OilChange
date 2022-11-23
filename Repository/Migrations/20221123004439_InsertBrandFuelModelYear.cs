using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class InsertBrandFuelModelYear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO [dbo].[VehicleBrand] ([Id],[Name],[Active],[UserUpdate],[CreationDate]) VALUES ('57414a44-7d33-4aff-9cfe-a8638383f74c','Ford',1,'2bdf4dce-b412-48fd-84ff-d3fe32a057af',GETDATE());
                INSERT INTO [dbo].[VehicleBrand] ([Id],[Name],[Active],[UserUpdate],[CreationDate]) VALUES ('e70067fb-27c7-4456-af52-9b8ad0f5599f','VW',1,'2bdf4dce-b412-48fd-84ff-d3fe32a057af',GETDATE());
                INSERT INTO [dbo].[VehicleBrand] ([Id],[Name],[Active],[UserUpdate],[CreationDate]) VALUES ('d04bf95b-7a20-4779-9b45-ac7c194a2537','Fiat',1,'2bdf4dce-b412-48fd-84ff-d3fe32a057af',GETDATE());
                INSERT INTO [dbo].[VehicleFuel] ([Id],[Name],[Active],[UserUpdate],[CreationDate]) VALUES ('79aed849-23ff-4d48-9b27-bbb24f812d32','Álcool',1,'2BDF4DCE-B412-48FD-84FF-D3FE32A057AF',GETDATE());
                INSERT INTO [dbo].[VehicleFuel] ([Id],[Name],[Active],[UserUpdate],[CreationDate]) VALUES ('b2a79208-7050-4780-b8ec-da60792ed066','Diesel',1,'2BDF4DCE-B412-48FD-84FF-D3FE32A057AF',GETDATE());
                INSERT INTO [dbo].[VehicleFuel] ([Id],[Name],[Active],[UserUpdate],[CreationDate]) VALUES ('911b6cc2-90e0-478f-b14b-8b971a6340ff','Flex',1,'2BDF4DCE-B412-48FD-84FF-D3FE32A057AF',GETDATE());
                INSERT INTO [dbo].[VehicleFuel] ([Id],[Name],[Active],[UserUpdate],[CreationDate]) VALUES ('f67fb0f4-2b74-4e1d-b275-934b2b42880e','Gasolina',1,'2BDF4DCE-B412-48FD-84FF-D3FE32A057AF',GETDATE());
                INSERT INTO [dbo].[VehicleModel] ([Id],[Name],[Active],[UserUpdate],[CreationDate]) VALUES ('8fb4b710-23bb-4831-af6e-5d2199476a5f','KA',1,'2bdf4dce-b412-48fd-84ff-d3fe32a057af', GETDATE());
                INSERT INTO [dbo].[VehicleModel] ([Id],[Name],[Active],[UserUpdate],[CreationDate]) VALUES ('0c8366ee-fdd4-43ca-981f-0085ca233438','Amarok',1,'2bdf4dce-b412-48fd-84ff-d3fe32a057af', GETDATE());
                INSERT INTO [dbo].[VehicleModel] ([Id],[Name],[Active],[UserUpdate],[CreationDate]) VALUES ('e56a67ff-167e-4b54-a3b0-43d49eddd963','Toro',1,'2bdf4dce-b412-48fd-84ff-d3fe32a057af', GETDATE());
                INSERT INTO [dbo].[VehicleYear] ([Id],[Name],[Active],[UserUpdate],[CreationDate]) VALUES ('c7619efb-01a1-44ac-a4dd-447cbf9b191d','2017',1,'2bdf4dce-b412-48fd-84ff-d3fe32a057af',GETDATE());
                INSERT INTO [dbo].[VehicleYear] ([Id],[Name],[Active],[UserUpdate],[CreationDate]) VALUES ('83593598-56dc-44ec-bf9a-34658de4efc6','2018',1,'2bdf4dce-b412-48fd-84ff-d3fe32a057af',GETDATE());
                INSERT INTO [dbo].[VehicleYear] ([Id],[Name],[Active],[UserUpdate],[CreationDate]) VALUES ('14356049-fa9d-4b38-aa4a-be9730f5c2fd','2019',1,'2bdf4dce-b412-48fd-84ff-d3fe32a057af',GETDATE());
                INSERT INTO [dbo].[VehicleYear] ([Id],[Name],[Active],[UserUpdate],[CreationDate]) VALUES ('addf70da-6e83-4b87-a443-0880ca949465','2020',1,'2bdf4dce-b412-48fd-84ff-d3fe32a057af',GETDATE());
                INSERT INTO [dbo].[VehicleYear] ([Id],[Name],[Active],[UserUpdate],[CreationDate]) VALUES ('73d865ab-e943-40dc-8e5d-28a49f5441e1','2021',1,'2bdf4dce-b412-48fd-84ff-d3fe32a057af',GETDATE());
                INSERT INTO [dbo].[VehicleYear] ([Id],[Name],[Active],[UserUpdate],[CreationDate]) VALUES ('832ae434-0f45-428f-9214-d303c3399654','2022',1,'2bdf4dce-b412-48fd-84ff-d3fe32a057af',GETDATE());
            ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
