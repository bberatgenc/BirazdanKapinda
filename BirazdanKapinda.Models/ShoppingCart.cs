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
    public class ShoppingCart
    {
        public int Id { get; set; }
        [DisplayName("ÜrünId")]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        [ValidateNever]
        [DisplayName("Ürün")]
        public Product Product {  get; set; }
        [Range(1, 1000, ErrorMessage = "Lütfen 1-100 arasında bir değer girin")]
        public int Count { get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        [DisplayName("KullanıcıId")]
        public string ApplicationUserId { get; set; }
        [NotMapped]
        [DisplayName("Fiyat")]
        public double Price { get; set; }
    }
}
