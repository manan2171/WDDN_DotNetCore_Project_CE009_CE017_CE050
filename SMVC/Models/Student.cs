using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMVC.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Fullname")]
        [DataType(DataType.Text)]
        [MaxLength(50)]
        [Display(Name = "Fullname")]
        public string fullname { get; set; }

        [Required(ErrorMessage = "Please enter Email Address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [MaxLength(100)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter Birthdate")]
        [DataType(DataType.Date)]
        [Display(Name = "BirthDate")]
        public string Birthdate { get; set; }

        [Required(ErrorMessage = "Please enter Phone number")]
        [MaxLength(10)]
        [Display(Name = "Phone No.")]
        public string phone { get; set; }

        [Required(ErrorMessage = "Please enter Address")]
        [DataType(DataType.Text)]
        [MaxLength(200)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter Gender")]
        [DataType(DataType.Text)]
        [MaxLength(10)]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter Branch")]
        [Display(Name = "Branch")]
        public int BranchId { get; set; }

        public Branch Branch { get; set; }

        [Required(ErrorMessage = "Please enter Degree")]
        [DataType(DataType.Text)]
        [MaxLength(10)]
        [Display(Name = "Degree")]
        public string Degree { get; set; }

        [Required(ErrorMessage = "Please enter Joining Year")]
        [Display(Name = "Joining Year")]
        public int year { get; set; }

        [Required(ErrorMessage = "Please enter Current Sem")]
        [Display(Name = "Current Sem")]
        public int Csem { get; set; }

        [Required(ErrorMessage = "Please enter Fee")]
        [Display(Name = "Fees")]
        public int Fee { get; set; }

        [Display(Name = "Fees Paid")]
        public bool Rfee { get; set; }

    }
}
