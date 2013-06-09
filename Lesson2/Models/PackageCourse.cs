using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lesson2.Models
{
    [Table("PackageCourse")]
    public class PackageCourse
    {
        [Key]
        public string PackageCode { get; set; }
        public string PackageName { get; set; }
        public int PackageLevel { get; set; }
        public decimal PackageFee { get; set; }
    }
}