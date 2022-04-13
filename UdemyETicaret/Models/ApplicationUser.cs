using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyETicaret.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string ApplicationUserName { get; set; }
        [Required]
        public string ApplicationUserSurname { get; set; }
        public string ApplicationUserAddress { get; set; }
        public string ApplicationUserCity { get; set; }
        public string ApplicationUserDistrict { get; set; }
        public string ApplicationUserPostCode { get; set; }
        public string ApplicationUserTelephone { get; set; }
        [NotMapped]
        public string Role { get; set; }
    }
}
