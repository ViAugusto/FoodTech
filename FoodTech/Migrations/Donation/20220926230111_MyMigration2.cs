using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodTech.Migrations.Donation
{
    public partial class MyMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "DonationModel",
                type: "text",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "Cep",
                table: "DonationModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "DonationModel",
                type: "text",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "DonationModel",
                type: "text",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Logradouro",
                table: "DonationModel",
                type: "text",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "DonationModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "DonationModel",
                type: "text",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "DeliverDonationModel",
                type: "text",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "Cep",
                table: "DeliverDonationModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "DeliverDonationModel",
                type: "text",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "DeliverDonationModel",
                type: "text",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Logradouro",
                table: "DeliverDonationModel",
                type: "text",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "DeliverDonationModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "DeliverDonationModel",
                type: "text",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "DonationModel");

            migrationBuilder.DropColumn(
                name: "Cep",
                table: "DonationModel");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "DonationModel");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "DonationModel");

            migrationBuilder.DropColumn(
                name: "Logradouro",
                table: "DonationModel");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "DonationModel");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "DonationModel");

            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "DeliverDonationModel");

            migrationBuilder.DropColumn(
                name: "Cep",
                table: "DeliverDonationModel");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "DeliverDonationModel");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "DeliverDonationModel");

            migrationBuilder.DropColumn(
                name: "Logradouro",
                table: "DeliverDonationModel");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "DeliverDonationModel");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "DeliverDonationModel");
        }
    }
}
