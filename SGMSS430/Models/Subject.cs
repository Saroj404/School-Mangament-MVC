using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGMSS430.Models
{
    public class Subject
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string SubjectName { get; set; }
        [Required]
        public string SubjectCode { get; set; }
    }
}