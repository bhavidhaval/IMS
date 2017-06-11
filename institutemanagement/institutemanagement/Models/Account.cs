using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace institutemanagement.Models
{
    public class Account
    {


    }

    public class loginviewmodel
    {

    }
    public class Registerviewmodel
    {

        [Required(ErrorMessage ="Member name is required")]
        public string  MemberName { get; set; }
        [Required(ErrorMessage ="last Name is required")]
        [StringLength(100, ErrorMessage = "Minimum {2} and Maximum {1} characters are allowed", MinimumLength = 3)]
        public string  LastName { get; set; }

        [Display (Name="Email Id")]
        [Required(ErrorMessage ="Email Address required")]
        [StringLength(100,ErrorMessage ="Min {5} and Maxmum 100 char allowed",MinimumLength =6)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "Minimum {2} and Maximum {1} characters are allowed", MinimumLength = 5)]
        public string  Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required")]
        [Compare("Password", ErrorMessage = "Password doesn't match")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "User type")]
        public int UserType { get; set; }

    }
}