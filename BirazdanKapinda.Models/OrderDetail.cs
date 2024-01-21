using BirazdanKapinda.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("SiparişId")]
        public int OrderHeaderId { get; set; }
        [ForeignKey("OrderHeaderId")]
        [ValidateNever]
        [DisplayName("Sipariş Başlığı")]
        public OrderHeader OrderHeader { get; set; }
        [Required]
        [DisplayName("ÜrünId")]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        [ValidateNever]
        [DisplayName("Ürün")]
        public Product Product { get; set; }
        [DisplayName("Adet")]
        public int Count { get; set; }
        [DisplayName("Fiyat")]
        public double Price { get; set; }

    }
}
