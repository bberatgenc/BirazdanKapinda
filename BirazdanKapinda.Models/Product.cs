using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirazdanKapinda.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Ürün Başlığı")]
        public string Title { get; set; }
        [Display(Name = "Ürün Açıklaması")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Ürün Kodu")]
        public string ProductCode { get; set; }
        [Required]
        [Display(Name = "Ürün Özellikleri")]
        public string ProductFeatures { get; set; }
        [Required]
        [Display(Name = "Stok Sayısı")]
        public int AoS { get; set; } //Amount of Stock --BBeratgenc
        [Required]
        [Display(Name ="Satış Fiyatı")]
        [Range(1,30000)]
        public double ListPrice { get; set; } //decimal kullanılabilir mi?
        [Display(Name = "KategoriId")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        [DisplayName("Kategori İsmi")]
        public Category Category { get; set; }
        [ValidateNever]
        [DisplayName("Ürün Fotoğrafı")]
        public List<ProductImage> ProductImages { get; set; }
    }
}
