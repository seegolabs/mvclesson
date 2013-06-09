using Lesson2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lesson2.Infrastructures
{
    public class DataContext : DbContext
    {
        public IDbSet<Registration> Registrations { get; set; }
        public IDbSet<PackageCourse> PackageCourses { get; set; }
    }
}