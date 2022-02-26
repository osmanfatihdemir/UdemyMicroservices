using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.WebUI.Models
{
    public class SigninInput
    {
        [Required]
        [Display(Name ="Email adress")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Your password")]
        public string Password { get; set; }
        [Display(Name = "Remember me")]
        public bool IsRemember { get; set; }

    }
}
