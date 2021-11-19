using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMVC.Models
{
    public class Branch
    {
        [Key]
        public int BranchId { get; set; }

        [Required(ErrorMessage = "Please enter Branch")]
        [Display(Name = "Branch Name")]
        [MaxLength(20)]
        public string Branchname { get; set; }

        [Required(ErrorMessage = "Please enter duration of course")]
        [Display(Name = "Duration of Course (Years)")]
        public int duration { get; set; }

        [Required(ErrorMessage = "Please enter fee")]
        [Display(Name = "Branch fees (Rupee)")]
        public int Branchfee { get; set; }
    }
}
