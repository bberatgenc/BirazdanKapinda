using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirazdanKapinda.Models
{
    public class OrderHeader
    {
        public int Id { get; set; }
        [DisplayName("KullanıcıId")]
        public string ApplicationUserId { get; set; }
        [ForeignKey(nameof(ApplicationUserId))]
        [ValidateNever]
        [DisplayName("Kullanıcı")]
        public ApplicationUser ApplicationUser { get; set; }
        [DisplayName("Sipariş Tarihi")]
        public DateTime OrderDate { get; set; }
        [DisplayName("Gönderim Tarihi")]
        public DateTime ShippingDate { get; set; }
        [DisplayName("Sipariş Toplamı")]
        public double OrderTotal { get; set; }
        [DisplayName("Sipariş Durumu")]
        public string? OrderStatus { get; set; }
        [DisplayName("Ödeme Durumu")]
        public string? PaymentStatus { get; set;}
        [DisplayName("Takip Numarası")]
        public string? TrackingNumber {  get; set; }
        [DisplayName("Kurye")]
        public string? Carrier { get;set; }
        [DisplayName("Ödeme Tarihi")]
        public DateTime PaymentDate { get; set; }
        [DisplayName("Son Ödeme Tarihi")]
        public DateOnly PaymentDueDate { get; set; }
        [DisplayName("OturumId")]
        public string? SessionId {  get; set; }
        [DisplayName("ÖdemeEntegrasyonuId")]
        public string? PaymentIntentId {  get; set; }
        [Required]
        [DisplayName("Telefon Numarası")]
        public string PhoneNumber { get; set; }
        [Required]
        [DisplayName("Açık Adres")]
        public string StreetAdress { get; set; }
        [Required]
        [DisplayName("İl")]
        public string City { get; set; }
        [Required]
        [DisplayName("İlçe")]
        public string State { get; set; }
        [Required]
        [DisplayName("Posta Kodu")]
        public string PostalCode { get; set; }
        [Required]
        [DisplayName("İsim-Soyisim")]
        public string Name { get; set; }
    }
}
