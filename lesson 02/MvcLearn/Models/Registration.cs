using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcLearn.Models
{
    [Table("Registration")]
    public class Registration
    {
        [Key]
        public string RegID { get; set; }
        public string RegName { get; set; }
        public DateTime RegDate { get; set; }
        public string Address { get; set; }
        public int Status { get; set; }
        public bool IsApproved { get; set; }
    }
}