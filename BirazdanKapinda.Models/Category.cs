using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BirazdanKapinda.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Kategori İsmi")]
        [MaxLength(40)]
        public string Name { get; set; }
        [DisplayName("Ürün Sırası")]
        [Range(1,100,ErrorMessage ="Sıra Sayısı 1-100 arası olmalıdır.")]
        public int DisplayOrder { get; set; }
    }
}
