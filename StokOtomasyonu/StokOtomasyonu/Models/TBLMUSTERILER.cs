//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StokOtomasyonu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TBLMUSTERILER
    {
        public int MUSTERIID { get; set; }
        [Required(ErrorMessage = "Musteri adi bos birakilamaz!")]
        [StringLength(50,ErrorMessage ="En fazla 50 karakterlik isim giriniz")]
        public string MUSTERIAD { get; set; }
        
        public string MUSTERISOYAD { get; set; }
    }
}