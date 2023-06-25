using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace FORMACIM.Models
{
    public class LoginModel
    {

        [Required]
        [Display(Name = "Kullanıcı Adınız")]
        public string Username { get; set; }


        [Required]
        [Display(Name = "Şifreniz")]
        public string Password { get; set; }

        [Display(Name = "Beni Hatırla")]

        public bool RememberMe { get; set; }
    }
}