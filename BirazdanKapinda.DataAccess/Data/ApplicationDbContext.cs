using BirazdanKapinda.Models;
using BulkyBook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BirazdanKapinda.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Elektrikli Ev Aletleri", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Konsol, Oyun ve Oyuncu Ekipmanları", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Ev-Ofis ve Yaşam", DisplayOrder = 3 });

            modelBuilder.Entity<Company>().HasData(
              new Company { Id = 1, Name = "Aydın Elektrik", StreetAdress="Merkez Mahallesi, Genç Sokak, No:44", City="Istanbul", PostalCode="34315",PhoneNumber="05555555555" },
              new Company { Id = 2, Name = "Dinçerler Ev ve Ofis Ürünleri", StreetAdress = "Sardunya Mahallesi, İlkbahar Sokak, No:34", City = "Antalya", PostalCode = "07242", PhoneNumber = "05455555555" },
              new Company { Id = 3, Name = "Elmas Kırtasiye", StreetAdress = "Cumhuriyet Mahallesi, İstikamet Sokak, No:35", City = "İzmir", PostalCode = "35034", PhoneNumber = "05345555555" });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Title = "Buharlı Ütü Makinesi",
                Description = "Daha hızlı ütüleme ve güçlü performans",
                ProductCode = "117a34",
                ProductFeatures = "Güç (Watt) - 2401 Watt ve Üzeri, Otomatik Kapanma - Var, Kireç Önleme - Var , Garanti Tipi - Resmi Distribütör Garantili",
                AoS = 19,
                ListPrice = 2400,
                CategoryId = 1
            },
            new Product
            {
                Id = 2,
                Title = "Şarjlı Matkap Usta Set",
                Description = "Akülü Çift Titan Şanzuman Premıum Li-on Şarjlı Matkap Usta Set",
                ProductCode = "222b07",
                ProductFeatures = "Voltaj - 12 Volt Max Performans 128 Volt, Akü tipi - 2 Adet Li-Ion BATARYA Akü kapasitesi - 1.5 Ah Max, Şarj Dolum süresi - 1 saat, Tork mekanizması - Var",
                AoS = 35,
                ListPrice = 800,
                CategoryId = 1
            },
            new Product
            {
                Id = 3,
                Title = "Led Ampul",
                Description = "Valta Led Ampul 220-240v 3000k E27 5w Sıcak Beyaz",
                ProductCode = "172t01",
                ProductFeatures = "Ampul Teknolojisi - Led Ampul, Dim Özelliği - Yok, Duy Tipi - E27, Güç (Watt) - 5 Watt",
                AoS = 955,
                ListPrice = 24,
                CategoryId = 2
            },
            new Product
            {
                Id = 4,
                Title = "Çift Kişilik Yatak Örtüsü",
                Description = "Çift Kişilik, Camel Renk, Pamuklu Yatak Örtüsü",
                ProductCode = "604n41",
                ProductFeatures = "Materyal - Pamuklu , Renk - Kahverengi, Desen - Çizgi, Boyut/Ebat - 250x260",
                AoS = 50,
                ListPrice = 1100,
                CategoryId = 2
            },
            new Product
            {
                Id = 5,
                Title = "Hesap Makinesi",
                Description = "240 Fonksiyonlu Bilimsel Hesap Makinesi",
                ProductCode = "252h00",
                ProductFeatures = "10+2 Haneli, İki Satırlı Dayanıklı Ekran, Temel İstatistik ve Matematik İşlemleri, Kayarak Takılan Koruyucu Sert Kapak",
                AoS = 350,
                ListPrice = 240,
                CategoryId = 2
            },
            new Product
            {
                Id = 6,
                Title = "Uçlu Kalem",
                Description = "Bordo Renk 0.7 Uçlu Kalem",
                ProductCode = "785f24",
                ProductFeatures = "Renk - Bordo, Çevirince ortaya çıkan ekstra silgi, Kauçuk kılıf ile rahat ve ergonomik tutuş",
                AoS = 350,
                ListPrice = 64,
                CategoryId = 3
            }
            );

        }
    }
}
