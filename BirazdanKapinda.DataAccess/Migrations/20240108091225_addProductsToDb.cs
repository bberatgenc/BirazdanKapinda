using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BirazdanKapinda.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductFeatures = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AoS = table.Column<int>(type: "int", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AoS", "Description", "ListPrice", "ProductCode", "ProductFeatures", "Title" },
                values: new object[,]
                {
                    { 1, 19, "Daha hızlı ütüleme ve güçlü performans", 2400.0, "117a34", "Güç (Watt) - 2401 Watt ve Üzeri, Otomatik Kapanma - Var, Kireç Önleme - Var , Garanti Tipi - Resmi Distribütör Garantili", "Buharlı Ütü Makinesi" },
                    { 2, 35, "Akülü Çift Titan Şanzuman Premıum Li-on Şarjlı Matkap Usta Set", 800.0, "222b07", "Voltaj - 12 Volt Max Performans 128 Volt, Akü tipi - 2 Adet Li-Ion BATARYA Akü kapasitesi - 1.5 Ah Max, Şarj Dolum süresi - 1 saat, Tork mekanizması - Var", "Şarjlı Matkap Usta Set" },
                    { 3, 955, "Valta Led Ampul 220-240v 3000k E27 5w Sıcak Beyaz", 24.0, "172t01", "Ampul Teknolojisi - Led Ampul, Dim Özelliği - Yok, Duy Tipi - E27, Güç (Watt) - 5 Watt", "Led Ampul" },
                    { 4, 50, "Çift Kişilik, Camel Renk, Pamuklu Yatak Örtüsü", 1100.0, "604n41", "Materyal - Pamuklu , Renk - Kahverengi, Desen - Çizgi, Boyut/Ebat - 250x260", "Çift Kişilik Yatak Örtüsü" },
                    { 5, 350, "240 Fonksiyonlu Bilimsel Hesap Makinesi", 240.0, "252h00", "10+2 Haneli, İki Satırlı Dayanıklı Ekran, Temel İstatistik ve Matematik İşlemleri, Kayarak Takılan Koruyucu Sert Kapak", "Hesap Makinesi" },
                    { 6, 350, "Bordo Renk 0.7 Uçlu Kalem", 64.0, "785f24", "Renk - Bordo, Çevirince ortaya çıkan ekstra silgi, Kauçuk kılıf ile rahat ve ergonomik tutuş", "Uçlu Kalem" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);
        }
    }
}
