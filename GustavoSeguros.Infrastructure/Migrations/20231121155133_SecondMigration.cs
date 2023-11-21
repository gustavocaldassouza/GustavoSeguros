using Microsoft.EntityFrameworkCore.Migrations;

namespace GustavoSeguros.Infrastructure.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seguros_Segurado_SeguradoId",
                table: "Seguros");

            migrationBuilder.DropForeignKey(
                name: "FK_Seguros_Veiculo_VeiculoId",
                table: "Seguros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Veiculo",
                table: "Veiculo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Segurado",
                table: "Segurado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seguros",
                table: "Seguros");

            migrationBuilder.RenameTable(
                name: "Veiculo",
                newName: "VEICULO");

            migrationBuilder.RenameTable(
                name: "Segurado",
                newName: "SEGURADO");

            migrationBuilder.RenameTable(
                name: "Seguros",
                newName: "SEGURO");

            migrationBuilder.RenameIndex(
                name: "IX_Seguros_VeiculoId",
                table: "SEGURO",
                newName: "IX_SEGURO_VeiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Seguros_SeguradoId",
                table: "SEGURO",
                newName: "IX_SEGURO_SeguradoId");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "VEICULO",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "SEGURADO",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "SEGURADO",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VEICULO",
                table: "VEICULO",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SEGURADO",
                table: "SEGURADO",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SEGURO",
                table: "SEGURO",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SEGURO_SEGURADO_SeguradoId",
                table: "SEGURO",
                column: "SeguradoId",
                principalTable: "SEGURADO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SEGURO_VEICULO_VeiculoId",
                table: "SEGURO",
                column: "VeiculoId",
                principalTable: "VEICULO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SEGURO_SEGURADO_SeguradoId",
                table: "SEGURO");

            migrationBuilder.DropForeignKey(
                name: "FK_SEGURO_VEICULO_VeiculoId",
                table: "SEGURO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VEICULO",
                table: "VEICULO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SEGURADO",
                table: "SEGURADO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SEGURO",
                table: "SEGURO");

            migrationBuilder.RenameTable(
                name: "VEICULO",
                newName: "Veiculo");

            migrationBuilder.RenameTable(
                name: "SEGURADO",
                newName: "Segurado");

            migrationBuilder.RenameTable(
                name: "SEGURO",
                newName: "Seguros");

            migrationBuilder.RenameIndex(
                name: "IX_SEGURO_VeiculoId",
                table: "Seguros",
                newName: "IX_Seguros_VeiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_SEGURO_SeguradoId",
                table: "Seguros",
                newName: "IX_Seguros_SeguradoId");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Veiculo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Segurado",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Segurado",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Veiculo",
                table: "Veiculo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Segurado",
                table: "Segurado",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seguros",
                table: "Seguros",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Seguros_Segurado_SeguradoId",
                table: "Seguros",
                column: "SeguradoId",
                principalTable: "Segurado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seguros_Veiculo_VeiculoId",
                table: "Seguros",
                column: "VeiculoId",
                principalTable: "Veiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
