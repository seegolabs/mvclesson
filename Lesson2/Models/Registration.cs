using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lesson2.Models
{
    [Table("Registration")]
    public class Registration
    {
        [Key]
        public int RegId { get; set; }
        public DateTime RegDate { get; set; }
        public string RegName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PackageCode { get; set; }
    }
}