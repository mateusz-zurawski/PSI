using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zwt.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please specify the username. ")]
        [Display(Name= "User Name:")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please specify your name. ")]
        [Display(Name = "Name:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please specify your last name. ")]
        [Display(Name = "Surname:")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please specify your password.")]
        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        public string  Password { get; set; }

        [Required(ErrorMessage = "Please specify your email.")]
        [Display(Name = "Email:")]
        [EmailAddress(ErrorMessage = "Please check your email field.")]
        public string Email { get; set; }

        [Display(Name = "Appointment Color: ")]
        public string Color { get; set; }
       
        [Display(Name = "Doktor")]
        public bool IsDoctor { get; set; }
    }
}
