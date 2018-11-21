using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class User
    {
        // Model including validators and error messages. Check the Microsoft dataannotation file to see what they do.
        [Required]
        [MinLength(4, ErrorMessage = "First name must be long than 4 characters.")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "First name must be long than 4 characters.")]
        public string LastName { get; set; }
        [Required]
        [Range(0,120, ErrorMessage = "Please enter a valid age.")]
        public int Age { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "You password must be longer than 8 characters.")]
        public string Password { get; set; }
    }
}