using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosAPI.Migrations
{
    public partial class Criandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "6e4a42e0-f0e8-4017-bdf4-525b95671442");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99997, "f5835a1f-3f0d-4ccd-a1c3-d6ba5f1dc62c", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62bb4b34-8861-460b-9dbf-68bd56b0eef9", "AQAAAAEAACcQAAAAEEL+9SR1iqmoQrdccAQHtVtSrr1U4bXVDbiNbgAn2tebyEmpVq8Jkwiha5tREhXHIA==", "28d9b538-f1d2-4b45-ba7f-dd7047064635" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "606179c9-335d-490b-b7a1-60778def7574");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d70f526e-0510-4d81-bd16-1eba1a880e83", "AQAAAAEAACcQAAAAEPojLD1keo6SNyH7SQTVVqw2OfbCHOWL2Z+TEHHZc3C2kJXuFY6LZCz34r4eqIomZQ==", "da0b7f01-c3f3-4630-903b-335d8e4d5f1b" });
        }
    }
}
