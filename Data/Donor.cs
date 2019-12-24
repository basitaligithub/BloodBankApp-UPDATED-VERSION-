using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankApplication.Data
{
    public class Donor : IdentityUser
    {
        [Required]
        [DisplayName("Full Name")]
        public string name { get; set; }

        [Required]
        [DisplayName("Age")]
        public int age { get; set; }
        [Required]
        [DisplayName("Gender")]
        public string gender { get; set; }
        [Required]
        [DisplayName("Blood Group")]
        public string bloodGroup { get; set; }
        [Required]
        [DisplayName("Street Address")]
        public string streetAddress { get; set; }
        [Required]
        [DisplayName("City")]
        public string city { get; set; }
        [Required]
        [DisplayName("Available")]
        public string availability { get; set; }
        [DisplayName("Diseases")]
        public string diseases { get; set; }
    }

}
