using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SMVC.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }

        [Required(ErrorMessage = "Please enter Subject")]
        [Display(Name = "Subject Name")]
        [MaxLength(20)]
        public string SubjectName { get; set; }

        [Required(ErrorMessage = "Please enter Credit")]
        [Display(Name = "Credit Name")]
        public int Credit { get; set; }

        [Required(ErrorMessage = "Please enter Branch")]
        [Display(Name = "Branch")]
        public int BranchId { get; set; }

        public Branch Branch { get; set; }
    }
}
