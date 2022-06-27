using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosAPI.Migrations
{
    public partial class AdicionandocustomIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "e1f1a9f5-46b1-42b8-b82b-9635e1f3128c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "6e07ab96-95c4-4c55-bcdf-b2322c2be9c6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5cb34b1-aa0f-4c79-aee2-ba8bc2d6d664", "AQAAAAEAACcQAAAAEIM68K/SNUdP2JS3fk2GonzQwa4kkKLE7TyNmeOsiL2UQnY5OrBvJtnGeUnnIXFz1Q==", "638eae5b-07d6-4e3a-b828-7057e21444a0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "f5835a1f-3f0d-4ccd-a1c3-d6ba5f1dc62c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "6e4a42e0-f0e8-4017-bdf4-525b95671442");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62bb4b34-8861-460b-9dbf-68bd56b0eef9", "AQAAAAEAACcQAAAAEEL+9SR1iqmoQrdccAQHtVtSrr1U4bXVDbiNbgAn2tebyEmpVq8Jkwiha5tREhXHIA==", "28d9b538-f1d2-4b45-ba7f-dd7047064635" });
        }
    }
}
