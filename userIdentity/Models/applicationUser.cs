using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace userIdentity.Models
{
    public class ApplicationUser :IdentityUser
    {
        [Required]
        [Display(Name ="username")]
        [StringLength(30)]
        public string Name { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Url]
        public string url { get; set; }
        
        

    }
}
