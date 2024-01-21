using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirazdanKapinda.Models
{
    public class Company
    {
        public int Id { get; set; } 
        [Required]
        [DisplayName("İsim-Soyisim")]
        public string Name { get; set; }
        [DisplayName("Açık Adres")]
        public string? StreetAdress { get; set; }
        [DisplayName("İl")]
        public string? City { get; set; }
        [DisplayName("İlçe")]
        public string? State { get; set; }
        [DisplayName("Posta Kodu")]
        public string? PostalCode { get; set; }
        [DisplayName("Telefon Numarası")]
        public string? PhoneNumber { get; set; }
    }
}
