using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCBasic_Viewdate.Models
{
    public class HRContext: DbContext
    {
        public HRContext() : base("name=HRContext")
        {

        }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}