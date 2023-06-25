using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FORMACIM.Models
{
    public class RegisterModel
    {

        public int Id { get; set; }

        [Required]
        [Display(Name = "Adınız")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Soyadınız")]
        public string Surname { get; set; }

        [Required]
        [Display(Name = "Kullanıcı adınız")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Lütfen e-mail adresinizi giriniz")]
        [Display(Name = "Emailiniz")]
        [EmailAddress]

        public string Email { get; set; }

        [Required]
        [Display(Name = "Şifreniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Tekrar Şifreniz")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Şifreleriniz uyuşmuyor!")]
        public string Repassword { get; set; }
    }
}