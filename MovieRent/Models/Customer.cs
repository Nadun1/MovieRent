using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRent.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage ="Name is Required")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [StringLength(255)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="Password donot match")]
        [DataType(DataType.Password)]
        public string RePassword { get; set; }

    }
}