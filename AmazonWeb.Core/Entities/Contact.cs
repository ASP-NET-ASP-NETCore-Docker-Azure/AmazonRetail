using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using AmazonWeb.Core.Entities.Base;

namespace AmazonWeb.Core.Entities
{
    public class Contact : Entity
    {
        [Required]
        public string Name { get; set; }
        [Phone]
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [MinLength(10)]
        [Required]
        public string Message { get; set; }
    }
}
