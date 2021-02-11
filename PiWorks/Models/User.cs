using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PiWorks.Models
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "Username")]
        public string Username { get; set; }
        [Display(Name = "Display Name")]
        public string DisplayName { get; set; }
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Display(Name = "User Roles")]
        public string UserRole { get; set; }
        [Display(Name = "Enabled")]
        public bool Enabled { get; set; }

        public bool IsNew => Id == default;
    }
}
