using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BirazdanKapinda.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Fotoğraf Url")]
        public string ImageUrl { get; set; }
        [DisplayName("ÜrünId")]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        [DisplayName("Ürün")]
        public Product Product { get; set; }
    }
}
