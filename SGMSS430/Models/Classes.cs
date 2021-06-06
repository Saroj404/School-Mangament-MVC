using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGMSS430.Models
{
    public class Classes
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string ClassName { get; set; }
        [Required]
        public string RoomNo { get; set; }
    }
}