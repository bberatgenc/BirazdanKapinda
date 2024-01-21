using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BirazdanKapinda.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addCompanyRecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAdress" },
                values: new object[,]
                {
                    { 1, "Istanbul", "Aydın Elektrik", "05555555555", "34315", null, "Merkez Mahallesi, Genç Sokak, No:44" },
                    { 2, "Antalya", "Dinçerler Ev ve Ofis Ürünleri", "05455555555", "07242", null, "Sardunya Mahallesi, İlkbahar Sokak, No:34" },
                    { 3, "İzmir", "Elmas Kırtasiye", "05345555555", "35034", null, "Cumhuriyet Mahallesi, İstikamet Sokak, No:35" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
