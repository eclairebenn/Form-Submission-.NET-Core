using System;
using System.ComponentModel.DataAnnotations;

namespace form_submission.Models
{
    public class User : BaseEntity
    {
        [Required]
        [MinLength(4)]
        [Display(Name = "First Name")]
        public string firstname {get; set;}
        [Required]
        [MinLength(4)]
        [Display(Name = "Last Name")]
        public string lastname {get; set;}
        [Required]
        [Range(0,150)]
        [Display(Name = "Age")]
        public int age {get; set;}
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string email {get;set;}
        [Required]
        [MinLength(8)]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string password {get;set;}

    }
}