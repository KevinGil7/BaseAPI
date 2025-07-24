using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormulariosAPI.Migrations
{
    /// <inheritdoc />
    public partial class userDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "294d249b-9b57-48c1-9689-11a91abb6447",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbde5b1b-31de-4e2d-a5f0-b27254a8900a", "AQAAAAIAAYagAAAAEE3VcUtNoaqb2xchrClhT4Sap5gT5BWYt76RKSiPdewPhwyPUHsFYMfyi6Jn6m4HHQ==", "5f58cae2-febf-4787-884e-74415fa7ca86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f284b3fd-f2cf-476e-a9b6-6560689cc48c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcb19120-bd99-4948-8564-c8751bd29e7a", "AQAAAAIAAYagAAAAEHnf4+wdrjVwCmNzv7TnS6gNSrio/b3bjkJ/pI5/3QrizN9AFhxKXoxik4cWDWim1g==", "78f4c917-e210-4d41-a8a3-f331ec86bba1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "294d249b-9b57-48c1-9689-11a91abb6447",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "193152b2-81a1-4ec0-8b5a-5f159dd84247", "$2a$13$9dd7.rT5Ehp.qIcGg17zA.c7i0.QS5qfR1xjqzXWdqh9jdrilTmmW", "ae7cd886-d142-47cb-aef3-4f35f6eecab7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f284b3fd-f2cf-476e-a9b6-6560689cc48c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "593b5331-03c9-4d8b-94e0-61f13c25e73c", "$2a$13$9dd7.rT5Ehp.qIcGg17zA.c7i0.QS5qfR1xjqzXWdqh9jdrilTmmW", "e8726448-a9c2-422f-9786-08c50cb948e2" });
        }
    }
}
