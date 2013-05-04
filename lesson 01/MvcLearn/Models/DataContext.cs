using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcLearn.Models
{
    public class DataContext : DbContext
    {
        public IDbSet<Registration> Registrations { get; set; }
    }
}