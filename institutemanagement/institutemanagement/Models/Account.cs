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

        [Required(ErrorMessage = "Email address is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [StringLength(100, ErrorMessage = "Minimum {2} and Maximum {1} characters are allowed", MinimumLength = 5)]
        [System.Web.Mvc.Remote("CheckEmailExist", "Account", ErrorMessage = "Email address is already used")]
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