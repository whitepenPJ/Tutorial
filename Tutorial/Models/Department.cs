using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Tutorial.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name="Department Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Department Sequence")]
        public int Sequence { get; set; }

        [Display(Name = "Active")]
        public bool Active { get; set; }
    }
}