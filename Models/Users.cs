using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace reg_login.Models
{
    public class User

    {
        [Required]
        [MinLength(2)]
        [Display(Name = "Your First Name:")]
        public string First_Name { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Your Last Name:")]
        public string Last_Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Your Email Address:")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Your Password:")]
        [MinLength(8)]
        public string Password { get; set; }

        // public User(string f, string l, int a, string p)

        // {
        //     First_Name = f;
        //     Last_Name = l;
        //     Age = a;
        //     Email = e;
        //     Password = p;
        // }

    }



}