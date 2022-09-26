using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace FoodTech.Migrations.Donation
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsuarioModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NomeUsuario = table.Column<string>(type: "text", nullable: false),
                    Senha = table.Column<string>(type: "text", nullable: false),
                    TipoUsuario = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientModel",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UsuarioModelId = table.Column<int>(type: "int", nullable: true),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Sobrenome = table.Column<string>(type: "text", nullable: false),
                    Cpf = table.Column<string>(type: "text", nullable: false),
                    Celular = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientModel", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_ClientModel_UsuarioModel_UsuarioModelId",
                        column: x => x.UsuarioModelId,
                        principalTable: "UsuarioModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientPjModel",
                columns: table => new
                {
                    IdClientePj = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UsuarioModelId = table.Column<int>(type: "int", nullable: true),
                    NomeFantasia = table.Column<string>(type: "text", nullable: false),
                    Cnpj = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientPjModel", x => x.IdClientePj);
                    table.ForeignKey(
                        name: "FK_ClientPjModel_UsuarioModel_UsuarioModelId",
                        column: x => x.UsuarioModelId,
                        principalTable: "UsuarioModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeliverDonationModel",
                columns: table => new
                {
                    IdDoacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ClientModelIdCliente = table.Column<int>(type: "int", nullable: true),
                    ClientPjModelIdClientePj = table.Column<int>(type: "int", nullable: true),
                    TipoDoacao = table.Column<string>(type: "text", nullable: false),
                    QuantidadeDoacao = table.Column<string>(type: "text", nullable: false),
                    FoiPago = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliverDonationModel", x => x.IdDoacao);
                    table.ForeignKey(
                        name: "FK_DeliverDonationModel_ClientModel_ClientModelIdCliente",
                        column: x => x.ClientModelIdCliente,
                        principalTable: "ClientModel",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeliverDonationModel_ClientPjModel_ClientPjModelIdClientePj",
                        column: x => x.ClientPjModelIdClientePj,
                        principalTable: "ClientPjModel",
                        principalColumn: "IdClientePj",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DonationModel",
                columns: table => new
                {
                    IdDoacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UsuarioModelId = table.Column<int>(type: "int", nullable: true),
                    ClientModelIdCliente = table.Column<int>(type: "int", nullable: true),
                    ClientPjModelIdClientePj = table.Column<int>(type: "int", nullable: true),
                    TipoDoacao = table.Column<string>(type: "text", nullable: false),
                    QuantidadeDoacao = table.Column<string>(type: "text", nullable: false),
                    FoiPago = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationModel", x => x.IdDoacao);
                    table.ForeignKey(
                        name: "FK_DonationModel_ClientModel_ClientModelIdCliente",
                        column: x => x.ClientModelIdCliente,
                        principalTable: "ClientModel",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DonationModel_ClientPjModel_ClientPjModelIdClientePj",
                        column: x => x.ClientPjModelIdClientePj,
                        principalTable: "ClientPjModel",
                        principalColumn: "IdClientePj",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DonationModel_UsuarioModel_UsuarioModelId",
                        column: x => x.UsuarioModelId,
                        principalTable: "UsuarioModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientModel_UsuarioModelId",
                table: "ClientModel",
                column: "UsuarioModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientPjModel_UsuarioModelId",
                table: "ClientPjModel",
                column: "UsuarioModelId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliverDonationModel_ClientModelIdCliente",
                table: "DeliverDonationModel",
                column: "ClientModelIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_DeliverDonationModel_ClientPjModelIdClientePj",
                table: "DeliverDonationModel",
                column: "ClientPjModelIdClientePj");

            migrationBuilder.CreateIndex(
                name: "IX_DonationModel_ClientModelIdCliente",
                table: "DonationModel",
                column: "ClientModelIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_DonationModel_ClientPjModelIdClientePj",
                table: "DonationModel",
                column: "ClientPjModelIdClientePj");

            migrationBuilder.CreateIndex(
                name: "IX_DonationModel_UsuarioModelId",
                table: "DonationModel",
                column: "UsuarioModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeliverDonationModel");

            migrationBuilder.DropTable(
                name: "DonationModel");

            migrationBuilder.DropTable(
                name: "ClientModel");

            migrationBuilder.DropTable(
                name: "ClientPjModel");

            migrationBuilder.DropTable(
                name: "UsuarioModel");
        }
    }
}
