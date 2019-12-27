using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankApplication.Data
{
    public class BloodBank
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [DisplayName("Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [DisplayName("Email Address")]
        public string email { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        [DisplayName("City")]
        public string City { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [DisplayName("Street Address")]
        public string address { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        [DisplayName("Contact Number")]
        public double PhoneNo { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public int Aplus { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public int Bplus { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public int ABplus { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public int Oplus { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public int Aminus { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public int Bminus { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public int ABminus { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public int Ominus { get; set; }


    }
}
