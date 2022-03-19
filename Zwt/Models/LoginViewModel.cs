using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zwt.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please specify the username. ")]
        [Display(Name = "User Name:")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please specify your password. ")]
        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
