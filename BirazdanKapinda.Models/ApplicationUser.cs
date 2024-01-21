using Microsoft.AspNetCore.Identity;
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
    public class ApplicationUser : IdentityUser
    {
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
        public string? PostalCode { get; set;}
        [DisplayName("FirmaId")]
        public int? CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        [ValidateNever]
        [DisplayName("Firma Adı")]
        public Company? Company { get; set; }
        [NotMapped]
        [DisplayName("Görev(İşlev)")]
        public string Role {  get; set; }
    }
}
